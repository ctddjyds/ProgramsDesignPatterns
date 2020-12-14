using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Interpreter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class InterpreterForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txCommand;
		private System.Windows.Forms.Button btCompute;
		private System.Windows.Forms.ListBox lsResults;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private KidData kdata;
		public InterpreterForm()
		{
			InitializeComponent();
			init();
		}
		private void init() 
		{
			kdata = new KidData ("50free.txt");
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
            this.lsResults = new System.Windows.Forms.ListBox();
            this.btCompute = new System.Windows.Forms.Button();
            this.txCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsResults
            // 
            this.lsResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsResults.ItemHeight = 20;
            this.lsResults.Location = new System.Drawing.Point(40, 181);
            this.lsResults.Name = "lsResults";
            this.lsResults.Size = new System.Drawing.Size(464, 164);
            this.lsResults.TabIndex = 2;
            // 
            // btCompute
            // 
            this.btCompute.Location = new System.Drawing.Point(184, 104);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(160, 39);
            this.btCompute.TabIndex = 1;
            this.btCompute.Text = "Compute";
            this.btCompute.Click += new System.EventHandler(this.btCompute_Click);
            // 
            // txCommand
            // 
            this.txCommand.Location = new System.Drawing.Point(16, 39);
            this.txCommand.Name = "txCommand";
            this.txCommand.Size = new System.Drawing.Size(512, 28);
            this.txCommand.TabIndex = 0;
            // 
            // InterpreterForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(556, 372);
            this.Controls.Add(this.lsResults);
            this.Controls.Add(this.btCompute);
            this.Controls.Add(this.txCommand);
            this.Name = "InterpreterForm";
            this.Text = "Interpreter demo";
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
			Application.Run(new InterpreterForm());
		}

		private void btCompute_Click(object sender, System.EventArgs e) 
		{
			parse();
		}
		private void parse() 
		{
			Parser par = new Parser (txCommand.Text ,kdata, lsResults);
			par.Execute ();
		}
	}
}
