using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Strategy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class StrategyForm : System.Windows.Forms.Form
	{
		private Strategy.LineButton btLine;
		private Strategy.BarButton btBar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StrategyForm()
		{
			InitializeComponent();
			init();		
		}
		private void init()
        {
			EventHandler evh = new EventHandler (ButtonClick);
			btLine.Click += evh;
			btBar.Click += evh;
			Context contxt = new Context("BarPlot");
			btBar.setContext(contxt);
            Context contxtLine = new Context("LinePlot");
            btLine.setContext(contxtLine);
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
            this.btLine = new Strategy.LineButton();
            this.btBar = new Strategy.BarButton();
            this.SuspendLayout();
            // 
            // btLine
            // 
            this.btLine.Location = new System.Drawing.Point(63, 39);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(160, 39);
            this.btLine.TabIndex = 0;
            this.btLine.Text = "Line plot";
            // 
            // btBar
            // 
            this.btBar.CommandName = null;
            this.btBar.Location = new System.Drawing.Point(288, 39);
            this.btBar.Name = "btBar";
            this.btBar.Size = new System.Drawing.Size(160, 39);
            this.btBar.TabIndex = 1;
            this.btBar.Text = "Bar plot";
            // 
            // StrategyForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(514, 186);
            this.Controls.Add(this.btBar);
            this.Controls.Add(this.btLine);
            this.Name = "StrategyForm";
            this.Text = "Plot strategies";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new StrategyForm());
		}

		private void ButtonClick(object sender, System.EventArgs e)
        {
			ICommand comd = (ICommand)sender;
			comd.Execute ();
		}
	}
}
