using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ChainOfResponsibility
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.ListBox lsFiles;
		private System.Windows.Forms.ListBox lsNocmd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txCommand;
		private System.Windows.Forms.Button btSend;
		private System.Windows.Forms.Panel pnlColor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Chain chn;

		public Form1()		
        {
			InitializeComponent();
			init();
		}
		private void init() 
        {
			//set up chains
			ColorChain clrChain = new ColorChain(pnlColor);
			FileChain flChain = new FileChain(lsFiles);
			NoCmdChain noChain = new NoCmdChain(lsNocmd);
			//create chain links
			chn = new ImageChain(picImage);
			chn.addToChain(clrChain);
			clrChain.addToChain(flChain);
			flChain.addToChain(noChain);
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lsFiles = new System.Windows.Forms.ListBox();
            this.lsNocmd = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSend = new System.Windows.Forms.Button();
            this.txCommand = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.Location = new System.Drawing.Point(48, 14);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(304, 218);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lsFiles
            // 
            this.lsFiles.ItemHeight = 18;
            this.lsFiles.Location = new System.Drawing.Point(417, 14);
            this.lsFiles.Name = "lsFiles";
            this.lsFiles.Size = new System.Drawing.Size(206, 166);
            this.lsFiles.TabIndex = 1;
            // 
            // lsNocmd
            // 
            this.lsNocmd.ItemHeight = 18;
            this.lsNocmd.Location = new System.Drawing.Point(688, 14);
            this.lsNocmd.Name = "lsNocmd";
            this.lsNocmd.Size = new System.Drawing.Size(209, 166);
            this.lsNocmd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSend);
            this.groupBox1.Controls.Add(this.txCommand);
            this.groupBox1.Location = new System.Drawing.Point(48, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send commands";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(80, 104);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(128, 38);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Send";
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txCommand
            // 
            this.txCommand.Location = new System.Drawing.Point(48, 39);
            this.txCommand.Name = "txCommand";
            this.txCommand.Size = new System.Drawing.Size(224, 28);
            this.txCommand.TabIndex = 0;
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(417, 258);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(223, 156);
            this.pnlColor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(924, 451);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsNocmd);
            this.Controls.Add(this.lsFiles);
            this.Controls.Add(this.picImage);
            this.Name = "Form1";
            this.Text = "Chain demo";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

		private void btSend_Click(object sender, System.EventArgs e) 
        {
			chn.sendToChain (txCommand.Text );
		}
	}
}
