using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CommandUndo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private CommandUndo.CommandButton btRed;
		private CommandUndo.CommandButton btUndo;
		private CommandUndo.CommandButton btBlue;
		private System.Windows.Forms.PictureBox pBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private BlueCommand blueC;
		private RedCommand redC;
		private UndoComd undoC;

		public Form1() 		{
			InitializeComponent();
			init();
		}
		private void init() {
			btBlue.setCommand (blueC=new BlueCommand (pBox));
			btRed.setCommand (redC=new RedCommand (pBox));
			btUndo.setCommand (undoC = new UndoComd ());
			
			EventHandler evh = new EventHandler (commandClick);
			btBlue.Click += evh;
			btRed.Click += evh;
			btUndo.Click += evh;
			pBox.Paint += new PaintEventHandler (paintHandler);
		
		}
		private void commandClick(object sender, EventArgs e) {
			//get the command
			ICommand comd = ((CommandHolder)sender).getCommand ();
			undoC.add (comd);	//add to undo list
			comd.Execute ();	//and execute it
		}
		public void paintHandler(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics ;
			blueC.draw(g);
			redC.draw (g);
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
            this.btUndo = new CommandUndo.CommandButton();
            this.btBlue = new CommandUndo.CommandButton();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btRed = new CommandUndo.CommandButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btUndo
            // 
            this.btUndo.Location = new System.Drawing.Point(272, 439);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(112, 52);
            this.btUndo.TabIndex = 2;
            this.btUndo.Text = "Undo";
            // 
            // btBlue
            // 
            this.btBlue.Location = new System.Drawing.Point(480, 439);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(128, 52);
            this.btBlue.TabIndex = 3;
            this.btBlue.Text = "Blue";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBox.Location = new System.Drawing.Point(64, 26);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(544, 400);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // btRed
            // 
            this.btRed.Location = new System.Drawing.Point(48, 439);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(112, 52);
            this.btRed.TabIndex = 1;
            this.btRed.Text = "Red";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(670, 526);
            this.Controls.Add(this.btBlue);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.btRed);
            this.Controls.Add(this.pBox);
            this.Name = "Form1";
            this.Text = "Undo command demo";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
