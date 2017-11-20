using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Proxy
{
	public class ProxyForm : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox PicBoxShow;
		private System.ComponentModel.Container components = null;
		private ImageMangeProxy imgProxy;
		private void init()
        {
			imgProxy = new ImageMangeProxy ();
		}
		//-----
		public ProxyForm()
        {
			InitializeComponent();
			init();
		}
		//-----
		protected override void Dispose( bool disposing )
        {
			if( disposing )
            {
				if (components != null)
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
            this.PicBoxShow = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxShow
            // 
            this.PicBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBoxShow.Location = new System.Drawing.Point(3, 3);
            this.PicBoxShow.Name = "PicBoxShow";
            this.PicBoxShow.Size = new System.Drawing.Size(387, 267);
            this.PicBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxShow.TabIndex = 0;
            this.PicBoxShow.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProxyForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(397, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicBoxShow);
            this.Name = "ProxyForm";
            this.Text = "Proxy demo";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShow)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new ProxyForm());
		}
		//-----
		private void button1_Click(object sender, System.EventArgs e)
        {
			PicBoxShow.Image = imgProxy.DrawImage ();
		}
	}
}
