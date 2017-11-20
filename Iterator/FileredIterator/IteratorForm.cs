using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FileredIterator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class IteratorForm : System.Windows.Forms.Form
    {
		private System.Windows.Forms.ListBox lsKids;
		private System.Windows.Forms.ListBox lsClubKids;
		private System.Windows.Forms.ComboBox cbClubs;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private KidData kdata;
		public IteratorForm() {
			InitializeComponent();
			init();
		}
		private void init() {
			kdata = new KidData("50free.txt");
			KidIterator kiter = kdata.getIterator ();
			while(kiter.MoveNext() )
            {
				Kid kd = (Kid)kiter.Current;
				lsKids.Items.Add (kd.getFrname() +" "+kd.getLname ());
			}
			IDictionaryEnumerator clubiter = kdata.getClubs ();
			while(clubiter.MoveNext ())
            {
				cbClubs.Items.Add ((string)clubiter.Value );
			}
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
            this.lsKids = new System.Windows.Forms.ListBox();
            this.lsClubKids = new System.Windows.Forms.ListBox();
            this.cbClubs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsKids
            // 
            this.lsKids.ItemHeight = 12;
            this.lsKids.Location = new System.Drawing.Point(10, 15);
            this.lsKids.Name = "lsKids";
            this.lsKids.Size = new System.Drawing.Size(153, 220);
            this.lsKids.TabIndex = 0;
            // 
            // lsClubKids
            // 
            this.lsClubKids.ItemHeight = 12;
            this.lsClubKids.Location = new System.Drawing.Point(192, 60);
            this.lsClubKids.Name = "lsClubKids";
            this.lsClubKids.Size = new System.Drawing.Size(144, 172);
            this.lsClubKids.TabIndex = 1;
            // 
            // cbClubs
            // 
            this.cbClubs.DropDownWidth = 120;
            this.cbClubs.Location = new System.Drawing.Point(192, 17);
            this.cbClubs.Name = "cbClubs";
            this.cbClubs.Size = new System.Drawing.Size(144, 20);
            this.cbClubs.TabIndex = 2;
            this.cbClubs.SelectedIndexChanged += new System.EventHandler(this.cbClubs_SelectedIndexChanged);
            // 
            // IteratorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(377, 266);
            this.Controls.Add(this.cbClubs);
            this.Controls.Add(this.lsClubKids);
            this.Controls.Add(this.lsKids);
            this.Name = "IteratorForm";
            this.Text = "Filtered Iterator demo";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new IteratorForm());
		}

		private void cbClubs_SelectedIndexChanged(object sender, System.EventArgs e) {
			string club = (String)cbClubs.SelectedItem ;
			FilteredIterator iter = kdata.getFilteredIterator ( club);
			lsClubKids.Items.Clear ();
			while(iter.MoveNext() ) {
				Kid kd = (Kid) iter.Current;
				lsClubKids.Items.Add (kd.getFrname() +" "+kd.getLname ());

			}
		}
	}
}
