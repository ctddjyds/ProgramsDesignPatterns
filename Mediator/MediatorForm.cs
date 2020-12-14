using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mediate
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MediatorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.ListBox lsSelected;
		private Mediate.KidList lsKids;
		private Mediate.CpyButton btCopy;
		private Mediate.ClrButton btClear;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Mediator med;
		public MediatorForm() 		{
			InitializeComponent();
			init();
		}
		//-----
		private void init() {
			//set up mediator and pass in referencs to controls
			med = new Mediator (btCopy, btClear, lsKids, lsSelected);
			btCopy.setMediator (med);	//set mediator ref in each control
			btClear.setMediator (med);
			lsKids.setMediator (med);
			med.setText (txName);		//tell mediator about text box
			//create event handler for all command objects
			EventHandler evh = new EventHandler (clickHandler);
			btClear.Click += evh;
			btCopy.Click += evh;
			lsKids.SelectedIndexChanged += evh;
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		//each control is a command object
		public void clickHandler(object obj, EventArgs e) {
			Command comd = (Command)obj;	//get command object
			comd.Execute ();				//and execute command
		}
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
            this.lsSelected = new System.Windows.Forms.ListBox();
            this.lsKids = new Mediate.KidList();
            this.btCopy = new Mediate.CpyButton();
            this.btClear = new Mediate.ClrButton();
            this.SuspendLayout();
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(16, 26);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(208, 28);
            this.txName.TabIndex = 0;
            // 
            // lsSelected
            // 
            this.lsSelected.ItemHeight = 18;
            this.lsSelected.Location = new System.Drawing.Point(336, 90);
            this.lsSelected.Name = "lsSelected";
            this.lsSelected.Size = new System.Drawing.Size(288, 256);
            this.lsSelected.TabIndex = 2;
            // 
            // lsKids
            // 
            this.lsKids.ItemHeight = 18;
            this.lsKids.Location = new System.Drawing.Point(16, 103);
            this.lsKids.Name = "lsKids";
            this.lsKids.Size = new System.Drawing.Size(272, 238);
            this.lsKids.TabIndex = 5;
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(336, 26);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(112, 39);
            this.btCopy.TabIndex = 6;
            this.btCopy.Text = "Copy";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(480, 26);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(112, 39);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            // 
            // MediatorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.lsKids);
            this.Controls.Add(this.lsSelected);
            this.Controls.Add(this.txName);
            this.Name = "MediatorForm";
            this.Text = "Mediator Form";
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
			Application.Run(new MediatorForm());
		}
	}
}
