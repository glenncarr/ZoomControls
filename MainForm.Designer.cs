
namespace ZoomControls
	{
	partial class MainForm
		{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
			{
			if ( disposing && ( components != null ) )
				{
				components.Dispose();
				}
			base.Dispose( disposing );
			}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnToggleAudio = new System.Windows.Forms.Button();
			this.btnToggleVideo = new System.Windows.Forms.Button();
			this.btnShowPeeps = new System.Windows.Forms.Button();
			this.btnShowChat = new System.Windows.Forms.Button();
			this.btnToggleShare = new System.Windows.Forms.Button();
			this.btnShowControls = new System.Windows.Forms.Button();
			this.btnShowShared = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnLeaveMeeting = new System.Windows.Forms.Button();
			this.timerWheelFontSizer = new ZoomControls.FontSizeTimer(this.components);
			this.flowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnToggleAudio
			// 
			this.btnToggleAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnToggleAudio.Location = new System.Drawing.Point(372, 1);
			this.btnToggleAudio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnToggleAudio.Name = "btnToggleAudio";
			this.btnToggleAudio.Size = new System.Drawing.Size(70, 39);
			this.btnToggleAudio.TabIndex = 5;
			this.btnToggleAudio.Text = "Toggle &Audio";
			this.btnToggleAudio.UseVisualStyleBackColor = false;
			this.btnToggleAudio.Click += new System.EventHandler(this.btnToggleAudio_Click);
			// 
			// btnToggleVideo
			// 
			this.btnToggleVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnToggleVideo.Location = new System.Drawing.Point(298, 1);
			this.btnToggleVideo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnToggleVideo.Name = "btnToggleVideo";
			this.btnToggleVideo.Size = new System.Drawing.Size(70, 39);
			this.btnToggleVideo.TabIndex = 4;
			this.btnToggleVideo.Text = "Toggle &Video";
			this.btnToggleVideo.UseVisualStyleBackColor = false;
			this.btnToggleVideo.Click += new System.EventHandler(this.btnToggleVideo_Click);
			// 
			// btnShowPeeps
			// 
			this.btnShowPeeps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnShowPeeps.Location = new System.Drawing.Point(224, 1);
			this.btnShowPeeps.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnShowPeeps.Name = "btnShowPeeps";
			this.btnShowPeeps.Size = new System.Drawing.Size(70, 39);
			this.btnShowPeeps.TabIndex = 3;
			this.btnShowPeeps.Text = "Show &Peeps";
			this.btnShowPeeps.UseVisualStyleBackColor = false;
			this.btnShowPeeps.Click += new System.EventHandler(this.btnShowPeeps_Click);
			// 
			// btnShowChat
			// 
			this.btnShowChat.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.btnShowChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnShowChat.Location = new System.Drawing.Point(150, 1);
			this.btnShowChat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnShowChat.Name = "btnShowChat";
			this.btnShowChat.Size = new System.Drawing.Size(70, 39);
			this.btnShowChat.TabIndex = 2;
			this.btnShowChat.Text = "Show &Chat";
			this.btnShowChat.UseVisualStyleBackColor = false;
			this.btnShowChat.Click += new System.EventHandler(this.btnShowChat_Click);
			// 
			// btnToggleShare
			// 
			this.btnToggleShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnToggleShare.Location = new System.Drawing.Point(76, 1);
			this.btnToggleShare.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnToggleShare.Name = "btnToggleShare";
			this.btnToggleShare.Size = new System.Drawing.Size(70, 39);
			this.btnToggleShare.TabIndex = 1;
			this.btnToggleShare.Text = "Toggle S&hare";
			this.btnToggleShare.UseVisualStyleBackColor = false;
			this.btnToggleShare.Click += new System.EventHandler(this.btnToggleShare_Click);
			// 
			// btnShowControls
			// 
			this.btnShowControls.BackColor = System.Drawing.Color.Fuchsia;
			this.btnShowControls.Location = new System.Drawing.Point(446, 1);
			this.btnShowControls.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnShowControls.Name = "btnShowControls";
			this.btnShowControls.Size = new System.Drawing.Size(70, 39);
			this.btnShowControls.TabIndex = 6;
			this.btnShowControls.Text = "Show &Controls";
			this.btnShowControls.UseVisualStyleBackColor = false;
			this.btnShowControls.Click += new System.EventHandler(this.btnShowControls_Click);
			// 
			// btnShowShared
			// 
			this.btnShowShared.BackColor = System.Drawing.Color.White;
			this.btnShowShared.Location = new System.Drawing.Point(2, 1);
			this.btnShowShared.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnShowShared.Name = "btnShowShared";
			this.btnShowShared.Size = new System.Drawing.Size(70, 39);
			this.btnShowShared.TabIndex = 0;
			this.btnShowShared.Text = "Show &Shared";
			this.btnShowShared.UseVisualStyleBackColor = false;
			this.btnShowShared.Click += new System.EventHandler(this.btnShowShared_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 2000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "button2";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(0, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "button3";
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Controls.Add(this.btnShowShared);
			this.flowLayoutPanel.Controls.Add(this.btnToggleShare);
			this.flowLayoutPanel.Controls.Add(this.btnShowChat);
			this.flowLayoutPanel.Controls.Add(this.btnShowPeeps);
			this.flowLayoutPanel.Controls.Add(this.btnToggleVideo);
			this.flowLayoutPanel.Controls.Add(this.btnToggleAudio);
			this.flowLayoutPanel.Controls.Add(this.btnShowControls);
			this.flowLayoutPanel.Controls.Add(this.btnLeaveMeeting);
			this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(593, 43);
			this.flowLayoutPanel.TabIndex = 3;
			// 
			// btnLeaveMeeting
			// 
			this.btnLeaveMeeting.BackColor = System.Drawing.Color.Gray;
			this.btnLeaveMeeting.ForeColor = System.Drawing.Color.White;
			this.btnLeaveMeeting.Location = new System.Drawing.Point(520, 1);
			this.btnLeaveMeeting.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnLeaveMeeting.Name = "btnLeaveMeeting";
			this.btnLeaveMeeting.Size = new System.Drawing.Size(70, 39);
			this.btnLeaveMeeting.TabIndex = 7;
			this.btnLeaveMeeting.Text = "Leave Meeting";
			this.btnLeaveMeeting.UseVisualStyleBackColor = false;
			this.btnLeaveMeeting.Click += new System.EventHandler(this.btnLeaveMeeting_Click);
			// 
			// timerWheelFontSizer
			// 
			this.timerWheelFontSizer.Delta = 0F;
			this.timerWheelFontSizer.Tick += new System.EventHandler(this.timerWheelFontSizer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 43);
			this.Controls.Add(this.flowLayoutPanel);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(90, 80);
			this.Name = "MainForm";
			this.Text = "Zoom Controls";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.flowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Button btnToggleAudio;
		private System.Windows.Forms.Button btnToggleVideo;
		private System.Windows.Forms.Button btnShowShared;
		private System.Windows.Forms.Button btnShowControls;
		private System.Windows.Forms.Button btnShowPeeps;
		private System.Windows.Forms.Button btnShowChat;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnToggleShare;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private FontSizeTimer timerWheelFontSizer;
		private System.Windows.Forms.Button btnLeaveMeeting;
		}
	}

