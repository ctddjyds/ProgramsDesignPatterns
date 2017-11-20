using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Observer
{
	/// <summary>
	/// Summary description for ColObserver.
	/// </summary>
	public class ColorObserverForm : System.Windows.Forms.Form, IObserver
    {
		private System.ComponentModel.Container components = null;
		private Brush bBrush;
		private System.Windows.Forms.PictureBox pic;
		private Font fnt;
		private Hashtable colors;
		private string colName;
		//-----
		public ColorObserverForm()
        {
			InitializeComponent();
			init();
		}
		//-----
		private void init()
        {
			fnt = new Font("arial", 18, FontStyle.Bold);
			bBrush = new SolidBrush(Color.Black);
			pic.Paint+= new PaintEventHandler (paintHandler);
			colors = new Hashtable ();
			colors.Add("red", Color.Red );
			colors.Add ("blue", Color.Blue );
			colors.Add ("green", Color.Green );
			colName = "";
		}
		//-----
		public void Update(string message)
        {
			colName = message;
			message = message.ToLower ();
			Color col = (Color)colors[message];
			pic.BackColor = col;
            if (!this.IsDisposed)
                this.Show();
		}
		//-----
		private void paintHandler(object sender, PaintEventArgs e)
        {
			 Graphics g = e.Graphics ;
			 g.DrawString(colName, fnt, bBrush, 20, 40);
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(29, 26);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(221, 164);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // ColObserver
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(281, 216);
            this.Controls.Add(this.pic);
            this.Name = "ColObserver";
            this.Text = "Color observer";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	}
}
