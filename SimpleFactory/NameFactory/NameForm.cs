using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using FFT;

namespace NameFactory
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class NameForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btCompute;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txFirst;
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.TextBox txLast;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private void init()
        {
		}
		public NameForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			init();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.txName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCompute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txFirst = new System.Windows.Forms.TextBox();
            this.txLast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(23, 63);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(172, 28);
            this.txName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name";
            // 
            // btCompute
            // 
            this.btCompute.Location = new System.Drawing.Point(23, 267);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(145, 37);
            this.btCompute.TabIndex = 2;
            this.btCompute.Text = "Compute";
            this.btCompute.Click += new System.EventHandler(this.btCompute_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(20, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last";
            // 
            // txFirst
            // 
            this.txFirst.Location = new System.Drawing.Point(83, 122);
            this.txFirst.Name = "txFirst";
            this.txFirst.Size = new System.Drawing.Size(112, 28);
            this.txFirst.TabIndex = 4;
            // 
            // txLast
            // 
            this.txLast.Location = new System.Drawing.Point(83, 206);
            this.txLast.Name = "txLast";
            this.txLast.Size = new System.Drawing.Size(112, 28);
            this.txLast.TabIndex = 4;
            // 
            // NameForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(292, 344);
            this.Controls.Add(this.txLast);
            this.Controls.Add(this.txFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCompute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txName);
            this.Name = "NameForm";
            this.Text = "Name splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new NameForm());
            Complex xComplex = new Complex(12.3f, 13.4f);
            Complex yComplex = new Complex(12.5f, 13.6f);
            Butterfly butterfly = CocoonFactory.getButterfly(12.4f);
            butterfly.Execute(xComplex, yComplex);
        }

		private void btCompute_Click(object sender, System.EventArgs e)
        {
			Namer nm = NameFactory.getName (txName.Text );
			txFirst.Text = nm.getFrname ();
			txLast.Text = nm.getLname ();
		}
	}
}
