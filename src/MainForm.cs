using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ZoomControls
	{
	public partial class MainForm : Form
		{
		[DllImport( "user32.dll", CharSet = CharSet.Unicode )]
		static extern IntPtr FindWindow( String lpClassName, String lpWindowName );

		[DllImport( "user32.dll" )]
		static extern bool SetForegroundWindow( IntPtr hWnd );

		[DllImport( "user32.dll" )]
		static extern bool IsWindowVisible( IntPtr hWnd );

		[DllImport( "user32.dll" )]
		private static extern int ShowWindow( IntPtr hWnd, uint Msg );
		private const uint SW_RESTORE = 0x09;

		struct ButtonInfo
			{
			public Color BackColor { get; set; }
			public Color ForeColor { get; set; }
			}

		private readonly Font defaultFont;
		private readonly float defaultFontSizeDelta;

		Dictionary<string, ButtonInfo> buttons = new Dictionary<string, ButtonInfo>();

		public MainForm()
			{
			InitializeComponent();

			this.defaultFont = new Font( this.Font.FontFamily, 8.25F );
			this.defaultFontSizeDelta = ( this.defaultFont.Size * 0.1F );
			this.MouseWheel += MainForm_MouseWheel;

			foreach ( var control in this.flowLayoutPanel.Controls )
				{
				Button b = control as Button;
				if ( b != null )
					{
					buttons[ b.Text ] = new ButtonInfo() { BackColor = b.BackColor, ForeColor = b.ForeColor };
					}
				}
			}

		private void btnToggleAudio_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%a" );
			}

		private void btnToggleVideo_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%v" );
			}

		private void btnShowShared_Click( object sender, EventArgs e )
			{
			IntPtr hwnd = FindWindow( "ZPContentViewWndClass", "Zoom" );
			if ( hwnd != IntPtr.Zero )
				{
				ShowWindow( hwnd, SW_RESTORE );
				SetForegroundWindow( hwnd );
				}
			}

		private void btnShowControls_Click( object sender, EventArgs e )
			{
			ShowControls();
			}

		private bool ShowControls()
			{
			bool visible = ZoomControlsVisible();
			if ( visible )
				SendKeys.SendWait( "^%+" );
			return visible;
			}

		private void btnShowPeeps_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%u" );
			}

		private void btnShowChat_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%h" );
			}

		private bool ZoomRunning()
			{
			return ( FindWindow( "ZPContentViewWndClass", "Zoom Meeting" ) != IntPtr.Zero );
			}

		private bool ZoomControlsVisible()
			{
			IntPtr hwnd = FindWindow( "ZPContentViewWndClass", "Zoom Meeting" );
			return hwnd != IntPtr.Zero && IsWindowVisible( hwnd );
			}

		bool zoomRunningPreviously = false;
		private async void timer_Tick( object sender, EventArgs e )
			{
			bool zoomRunning = ZoomRunning();
			EnableButtons( zoomRunning );
			if ( zoomRunning != zoomRunningPreviously )
				{
				zoomRunningPreviously = zoomRunning;
				await SetSlackStatus( zoomRunning );
				}
			}

		private void EnableButtons( bool enable )
			{
			foreach ( var control in this.flowLayoutPanel.Controls )
				{
				Button b = control as Button;
				if ( b != null )
					{
					b.ForeColor = ( enable ? buttons[ b.Text ].ForeColor : SystemColors.ControlText );
					b.BackColor = ( enable ? buttons[ b.Text ].BackColor : SystemColors.Control );
					b.Enabled = enable;
					}
				}
			}

		private void btnToggleShare_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%s" );
			}

		private void btnLeaveMeeting_Click( object sender, EventArgs e )
			{
			ShowControls();
			SendKeys.SendWait( "%q" );
			}

		static bool IsVisibleOnAnyScreen( Point formLocation, Size formSize )
			{
			Rectangle formPosition = new Rectangle( formLocation, formSize );
			foreach ( Screen screen in Screen.AllScreens )
				{
				if ( screen.WorkingArea.IntersectsWith( formPosition ) )
					{
					return true;
					}
				}
			return false;
			}

		private void MainForm_Load( object sender, EventArgs e )
			{
			if ( Settings.Default.FontSize != 0 )
				{
				this.setFontSize( Settings.Default.FontSize );
				}
			if ( !Settings.Default.Location.IsEmpty && IsVisibleOnAnyScreen( Settings.Default.Location, Settings.Default.Size ) )
				{
				this.Location = Settings.Default.Location;
				this.Size = Settings.Default.Size;
				}
			EnableButtons( false );
			}

		private void MainForm_FormClosed( object sender, FormClosedEventArgs e )
			{
			Settings.Default.Size = this.Size;
			Settings.Default.Location = this.Location;
			Settings.Default.FontSize = this.Font.Size;
			Settings.Default.Save();
			}

		private void MainForm_MouseWheel( object sender, MouseEventArgs e )
			{
			if ( ModifierKeys == Keys.Control )
				{
				this.timerWheelFontSizer.Stop();
				this.timerWheelFontSizer.Interval = 50;
				this.timerWheelFontSizer.Delta = ( e.Delta > 0 ? this.defaultFontSizeDelta : -this.defaultFontSizeDelta );
				this.timerWheelFontSizer.Start();
				}
			}

		private void timerWheelFontSizer_Tick( object sender, EventArgs e )
			{
			this.timerWheelFontSizer.Stop();
			this.setFontSize( this.Font.Size + this.timerWheelFontSizer.Delta );
			}

		private void setFontSize( float fontSize )
			{
			if ( fontSize >= this.defaultFont.Size * 0.9F )
				{
				Application.DoEvents();

				this.SuspendLayout();
				this.Font = new Font( this.Font.FontFamily, fontSize );
				this.ResumeLayout();
				}
			}

		private static async Task SetSlackStatus( bool zoomIsRunning )
			{
			using ( var client = new HttpClient() )
				{
				using ( var request = new HttpRequestMessage( HttpMethod.Post, "https://slack.com/api/users.profile.set" ) )
					{
					request.Headers.Add( "Authorization", "Bearer xoxp-2524887812-2524887816-1793032636676-5c2e5fd5b7067556a6b99c2ecd66d064" );
					var body = new slack_profile_request()
						{
						profile = new profile()
							{
							status_text = "On a Zoom call",
							status_emoji = ":zoom-call:",
							status_expiration = 0,
							}
						};
					if ( !zoomIsRunning )
						{
						body.profile.status_text = "";
						body.profile.status_emoji = "";
						}
					string json = JsonConvert.SerializeObject( body );
					using ( var stringContent = new StringContent( json, Encoding.UTF8, "application/json" ) )
						{
						request.Content = stringContent;

						using ( var response = await client
							.SendAsync( request )
							.ConfigureAwait( false ) )
							{
							response.EnsureSuccessStatusCode();
							}
						}
					}
				}

			}
		}

	public class slack_profile_request
		{
		public profile profile { get; set; }
		}

	public class profile
		{
		public string status_text { get; set; }
		public string status_emoji { get; set; }
		public int status_expiration { get; set; }
		}
	}
