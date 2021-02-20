namespace ZoomControls
	{
	class FontSizeTimer : System.Windows.Forms.Timer
		{
		public FontSizeTimer( System.ComponentModel.IContainer components )
			: base( components )
			{
			}

		public float Delta { get; set; }
		}
	}
