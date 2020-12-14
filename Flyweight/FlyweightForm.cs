using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Flyweight {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FlyweightForm : System.Windows.Forms.Form
    {
		private System.Windows.Forms.PictureBox Pic;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ArrayList names;
		private Folder fol;
		private const int pLeft = 30;
		private const int pTop  = 30;
		private const int HSpace = 70;
		private const int VSpace = 80;
		private const int rowMax = 2;
		private string selectedName;
		private csPatterns.Rectangle rect;
		private FolderFactory folFact;
		private Positioner posn;
		//-----
		private void init()
        {
			names = new ArrayList();
			names.Add("Adam");
			names.Add("Bill");
			names.Add("Charlie");
			names.Add("Dave");
			names.Add("Edward");
			names.Add("Fred");
			names.Add("George");
			fol = new Folder(Color.Bisque);
			selectedName = (string)names[0];
			Pic.Paint += new PaintEventHandler (picPaint);
			rect = new csPatterns.Rectangle();
			rect.setSize(50, 30);
			folFact = new FolderFactory();
			posn = new Positioner ();
		}
//-----
		public FlyweightForm()
        {
			InitializeComponent();
			init();
		}
		//-----------
		private void picPaint(object sender,  PaintEventArgs e )
        {
			Graphics g = e.Graphics;
			posn.reset ();
			for(int i = 0; i < names.Count; i++) 
			{
				fol = folFact.getFolder(selectedName.Equals(  (string)names[i]) );
				fol.draw(g, posn.nextX() , posn.nextY (), (string)names[i]);
				posn.incr();	  
			}										   
		}
		//-----
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
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic.Location = new System.Drawing.Point(17, 14);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(543, 400);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            // 
            // FlyweightForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(586, 439);
            this.Controls.Add(this.Pic);
            this.Name = "FlyweightForm";
            this.Text = "Flyweight demo";
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
			Application.Run(new FlyweightForm());
		}
//-----
		private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
			string oldname = selectedName;  //save old name
			bool found = false;
			posn.reset ();
			int i = 0;
			selectedName = "";
			while (i < names.Count && ! found)
            {
				rect.init (posn.nextX() , posn.nextY ());
				//see if a rectangle contains the mouse
				if (rect.contains(e.X, e.Y) )
				{
					selectedName = (string)names[i];
					found = true;
				}		
				posn.incr ();
				i++;
			}
			//only refresh if mouse in new rectangle
			if(  !oldname.Equals ( selectedName))
            {
				Pic.Refresh();
			}
		}
	}
}