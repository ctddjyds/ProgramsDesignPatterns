using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DeepSexClone
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SwimPrototypeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lsKids;
		private System.Windows.Forms.ListBox lsNewKids;
		private System.Windows.Forms.Button btClone;
		private SexSwimData swdata;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton opFemale;
		private System.Windows.Forms.RadioButton opMale;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private void init()
        {
			swdata = new SexSwimData ("swimmers.txt");
			reload();
		}
		private void reload()
        {
			lsKids.Items.Clear ();
			swdata.moveFirst ();
			while (swdata.hasMoreElements() )
            {
				Swimmer sw = swdata.getSwimmer ();
				lsKids.Items.Add (sw.getName() );
			}
		
		}
		public SwimPrototypeForm()
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
            this.lsKids = new System.Windows.Forms.ListBox();
            this.btClone = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lsNewKids = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opMale = new System.Windows.Forms.RadioButton();
            this.opFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsKids
            // 
            this.lsKids.ItemHeight = 12;
            this.lsKids.Location = new System.Drawing.Point(10, 26);
            this.lsKids.Name = "lsKids";
            this.lsKids.Size = new System.Drawing.Size(153, 172);
            this.lsKids.TabIndex = 0;
            // 
            // btClone
            // 
            this.btClone.Location = new System.Drawing.Point(173, 26);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(57, 26);
            this.btClone.TabIndex = 2;
            this.btClone.Text = "-->";
            this.btClone.Click += new System.EventHandler(this.btClone_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(173, 164);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(57, 26);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "<---";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lsNewKids
            // 
            this.lsNewKids.ItemHeight = 12;
            this.lsNewKids.Location = new System.Drawing.Point(250, 26);
            this.lsNewKids.Name = "lsNewKids";
            this.lsNewKids.Size = new System.Drawing.Size(153, 172);
            this.lsNewKids.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opMale);
            this.groupBox1.Controls.Add(this.opFemale);
            this.groupBox1.Location = new System.Drawing.Point(173, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(57, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // opMale
            // 
            this.opMale.Location = new System.Drawing.Point(10, 34);
            this.opMale.Name = "opMale";
            this.opMale.Size = new System.Drawing.Size(38, 18);
            this.opMale.TabIndex = 1;
            this.opMale.Text = "M";
            // 
            // opFemale
            // 
            this.opFemale.Checked = true;
            this.opFemale.Location = new System.Drawing.Point(10, 17);
            this.opFemale.Name = "opFemale";
            this.opFemale.Size = new System.Drawing.Size(38, 17);
            this.opFemale.TabIndex = 0;
            this.opFemale.TabStop = true;
            this.opFemale.Text = "F";
            // 
            // SwimPrototypeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(427, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.lsNewKids);
            this.Controls.Add(this.lsKids);
            this.Name = "SwimPrototypeForm";
            this.Text = "Simple Prototype";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SwimPrototypeForm());
		}

		private void btClone_Click(object sender, System.EventArgs e)
        {
			SexSwimData newSd = (SexSwimData)swdata.Clone ();		
			newSd.sort (opFemale.Checked );
			lsNewKids.Items.Clear() ;
			while(newSd.hasMoreElements() )
            {
				Swimmer sw = (Swimmer)newSd.getSwimmer ();
				lsNewKids.Items.Add (sw.getName() );
			}
		}

		private void btBack_Click(object sender, System.EventArgs e)
        {
			reload();
		}
	}
}
