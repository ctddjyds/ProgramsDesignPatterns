using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Seeding
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SeedingForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lsEvents;
		private System.Windows.Forms.ListBox lsSwimmers;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ArrayList events;

		private void init()
        {
			//create array of events
			events = new ArrayList ();
			lsEvents.Items.Add ("500 Free");
			lsEvents.Items.Add ("100 Free");
			//and read in their data
			events.Add (new TimedFinalEvent ("500free.txt", 6));
			events.Add (new PrelimEvent ("100free.txt", 6));
		}
		public SeedingForm()
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
            this.lsEvents = new System.Windows.Forms.ListBox();
            this.lsSwimmers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsEvents
            // 
            this.lsEvents.ItemHeight = 12;
            this.lsEvents.Location = new System.Drawing.Point(10, 26);
            this.lsEvents.Name = "lsEvents";
            this.lsEvents.Size = new System.Drawing.Size(134, 64);
            this.lsEvents.TabIndex = 0;
            this.lsEvents.SelectedIndexChanged += new System.EventHandler(this.lsEvents_SelectedIndexChanged);
            // 
            // lsSwimmers
            // 
            this.lsSwimmers.ItemHeight = 12;
            this.lsSwimmers.Location = new System.Drawing.Point(173, 26);
            this.lsSwimmers.Name = "lsSwimmers";
            this.lsSwimmers.Size = new System.Drawing.Size(230, 172);
            this.lsSwimmers.TabIndex = 1;
            // 
            // SeedingForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(427, 220);
            this.Controls.Add(this.lsSwimmers);
            this.Controls.Add(this.lsEvents);
            this.Name = "SeedingForm";
            this.Text = "Seeding Factory";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SeedingForm());
		}

		private void lsEvents_SelectedIndexChanged(object sender, System.EventArgs e)
        {
			int index = lsEvents.SelectedIndex ;
			EventCreator ev = (EventCreator)events[index];
			SeedingProduct sd = ev.getSeeding();
			IEnumerator en  = sd.getSwimmers();
			lsSwimmers.Items.Clear() ;
			while(en.MoveNext ())
            {
				Swimmer sw = (Swimmer)en.Current ;
				lsSwimmers.Items.Add(sw.getHeat()+" "+sw.getLane()+" "+sw.getName()+" "+sw.getTime());
			}
		}
	}
}
