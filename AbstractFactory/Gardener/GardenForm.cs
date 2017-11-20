using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Gardener
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class GardenForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private Gardener.GardenPicture gdPic1;
		private System.Windows.Forms.RadioButton opAnnual;
		private System.Windows.Forms.RadioButton opVegetable;
		private System.Windows.Forms.RadioButton opPerennial;
		private System.Windows.Forms.CheckBox ckCenter;
		private System.Windows.Forms.CheckBox ckBorder;
		private System.Windows.Forms.CheckBox ckShade;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Garden garden;
		private void init()
        {
		}
		public GardenForm()
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
            this.ckCenter = new System.Windows.Forms.CheckBox();
            this.gdPic1 = new Gardener.GardenPicture();
            this.opVegetable = new System.Windows.Forms.RadioButton();
            this.ckBorder = new System.Windows.Forms.CheckBox();
            this.ckShade = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opPerennial = new System.Windows.Forms.RadioButton();
            this.opAnnual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdPic1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckCenter
            // 
            this.ckCenter.Location = new System.Drawing.Point(192, 224);
            this.ckCenter.Name = "ckCenter";
            this.ckCenter.Size = new System.Drawing.Size(77, 17);
            this.ckCenter.TabIndex = 2;
            this.ckCenter.Text = "Center";
            this.ckCenter.CheckedChanged += new System.EventHandler(this.ckCenter_CheckedChanged);
            // 
            // gdPic1
            // 
            this.gdPic1.BackColor = System.Drawing.Color.Transparent;
            this.gdPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gdPic1.Location = new System.Drawing.Point(183, 3);
            this.gdPic1.Name = "gdPic1";
            this.gdPic1.Size = new System.Drawing.Size(221, 206);
            this.gdPic1.TabIndex = 1;
            this.gdPic1.TabStop = false;
            // 
            // opVegetable
            // 
            this.opVegetable.Location = new System.Drawing.Point(19, 52);
            this.opVegetable.Name = "opVegetable";
            this.opVegetable.Size = new System.Drawing.Size(96, 17);
            this.opVegetable.TabIndex = 1;
            this.opVegetable.Text = "Vegetable";
            this.opVegetable.CheckedChanged += new System.EventHandler(this.opVegetable_CheckedChanged);
            // 
            // ckBorder
            // 
            this.ckBorder.Location = new System.Drawing.Point(269, 224);
            this.ckBorder.Name = "ckBorder";
            this.ckBorder.Size = new System.Drawing.Size(77, 17);
            this.ckBorder.TabIndex = 3;
            this.ckBorder.Text = "Border";
            this.ckBorder.CheckedChanged += new System.EventHandler(this.ckBorder_CheckedChanged);
            // 
            // ckShade
            // 
            this.ckShade.Location = new System.Drawing.Point(346, 224);
            this.ckShade.Name = "ckShade";
            this.ckShade.Size = new System.Drawing.Size(76, 17);
            this.ckShade.TabIndex = 3;
            this.ckShade.Text = "Shade";
            this.ckShade.CheckedChanged += new System.EventHandler(this.ckShade_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opPerennial);
            this.groupBox1.Controls.Add(this.opVegetable);
            this.groupBox1.Controls.Add(this.opAnnual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Garden type";
            // 
            // opPerennial
            // 
            this.opPerennial.Location = new System.Drawing.Point(19, 78);
            this.opPerennial.Name = "opPerennial";
            this.opPerennial.Size = new System.Drawing.Size(96, 17);
            this.opPerennial.TabIndex = 2;
            this.opPerennial.Text = "Perennial";
            this.opPerennial.CheckedChanged += new System.EventHandler(this.opPerennial_CheckedChanged);
            // 
            // opAnnual
            // 
            this.opAnnual.Location = new System.Drawing.Point(19, 26);
            this.opAnnual.Name = "opAnnual";
            this.opAnnual.Size = new System.Drawing.Size(106, 17);
            this.opAnnual.TabIndex = 0;
            this.opAnnual.Text = "Annual";
            this.opAnnual.CheckedChanged += new System.EventHandler(this.opAnnual_CheckedChanged);
            // 
            // GardenForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(429, 258);
            this.Controls.Add(this.ckShade);
            this.Controls.Add(this.ckBorder);
            this.Controls.Add(this.ckCenter);
            this.Controls.Add(this.gdPic1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GardenForm";
            this.Text = "Garden planner";
            ((System.ComponentModel.ISupportInitialize)(this.gdPic1)).EndInit();
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
			Application.Run(new GardenForm());
		}

		
		private void opAnnual_CheckedChanged(object sender, EventArgs e)
        {
			setGarden( new AnnualGarden ());
		}
		//-----
		private void opVegetable_CheckedChanged(object sender, EventArgs e)
        {
			setGarden( new VeggieGarden ());
		}
		//-----
		private void opPerennial_CheckedChanged(object sender, EventArgs e)
        {
			setGarden( new PerennialGarden ());
		}		
		//-----
		private void setGarden(Garden gd)
        {
			garden = gd;			//save current garden
			gdPic1.setGarden ( gd);	//tell picture bos
			gdPic1.Refresh ();		//repaint it
			ckCenter.Checked =false;	//clear all
			ckBorder.Checked = false;	//check
			ckShade.Checked = false;	//boxes
		}
		private void ckCenter_CheckedChanged(object sender, System.EventArgs e)
        {
			garden.setCenter ();
			gdPic1.Refresh ();
		}
		//-----
		private void ckBorder_CheckedChanged(object sender, System.EventArgs e)
        {
			garden.setBorder();
			gdPic1.Refresh ();
		}
		//-----
		private void ckShade_CheckedChanged(object sender, System.EventArgs e)
        {
			garden.setShade ();
			gdPic1.Refresh ();
		}
	}
}
