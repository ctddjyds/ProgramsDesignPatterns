using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TemplateMethod
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TemplateMethodForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox Pic;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ArrayList triangles;
		public TemplateMethodForm()
		{
			InitializeComponent();
			init();			
		}
		private void init()
        {
			triangles = new ArrayList();
			StdTriangle t1 = new StdTriangle(new Point(10, 10), 
				new Point(150, 50), 
				new Point(100, 75));
			IsocelesTriangle t2 = new IsocelesTriangle( 
				new Point(150, 100), new Point(240, 40), 
				new Point(175, 150));
			triangles.Add(t1);
			triangles.Add(t2);
			Pic.Paint+= new PaintEventHandler (TPaint);
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            this.Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic.Location = new System.Drawing.Point(29, 9);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(307, 206);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            // 
            // TemplateMethodForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(366, 241);
            this.Controls.Add(this.Pic);
            this.Name = "TemplateMethodForm";
            this.Text = "Template demo";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TemplateMethodForm());
		}
		private void TPaint (object sender,  System.Windows.Forms.PaintEventArgs e )
        {
			Graphics g = e.Graphics;
			for (int i = 0; i<  triangles.Count ; i++)
            {
				TriangleAbstract t = (TriangleAbstract)triangles[i];
				t.draw(g);
			}
		}

	}
}
