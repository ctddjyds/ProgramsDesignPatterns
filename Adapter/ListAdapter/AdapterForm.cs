using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListAdapter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class AdapterForm : Form
	{
		private System.Windows.Forms.ListBox lsKids;
		private System.Windows.Forms.ListBox lsNewKids;
		private System.Windows.Forms.Button btClone;
		private SwimData swdata;
		private ClassListAdapter lskids, lsnewKids;
		private System.Windows.Forms.Button putBack;
        private MyList m_lsNewKids;
        private MyList m_lsKids;
        private GridAdapter m_lsNewGridKids;
        private System.Windows.Forms.DataGrid dGrid;
        private DataTable dTable;
        private Button button1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
		private void init() {
			swdata = new SwimData ("swimmers.txt");
			lskids= new ClassListAdapter (lsKids);
			lsnewKids =  new ClassListAdapter (lsNewKids);
            createGrid();
            m_lsNewGridKids = new GridAdapter(dGrid);
            reload();
		}
        private void createGrid()
        {
            dTable = new DataTable("Kids");
            dTable.MinimumCapacity = 100;
            dTable.CaseSensitive = false;

            DataColumn column =
                new DataColumn("Frname", System.Type.GetType("System.String"));
            dTable.Columns.Add(column);
            column = new DataColumn("Lname", System.Type.GetType("System.String"));
            dTable.Columns.Add(column);
            column = new DataColumn("Age", System.Type.GetType("System.Int16"));

            dTable.Columns.Add(column);

            dGrid.DataSource = dTable;
            dGrid.CaptionVisible = false;    //no caption
            dGrid.RowHeadersVisible = false; //no row headers
            dGrid.EndInit();

        }
        private void reload() {
			lskids.Clear ();
            m_lsKids.Clear();
			swdata.moveFirst ();
			while (swdata.hasMoreElements() )
            {
				Swimmer sw = swdata.getSwimmer ();
				lskids.Add (sw.getName() );
                m_lsKids.Add(sw.getName());
            }
		
		}
		public AdapterForm()
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
            this.lsNewKids = new System.Windows.Forms.ListBox();
            this.putBack = new System.Windows.Forms.Button();
            this.m_lsNewKids = new ListAdapter.MyList();
            this.m_lsKids = new ListAdapter.MyList();
            this.dGrid = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lsKids
            // 
            this.lsKids.ItemHeight = 12;
            this.lsKids.Location = new System.Drawing.Point(14, 26);
            this.lsKids.Name = "lsKids";
            this.lsKids.Size = new System.Drawing.Size(153, 172);
            this.lsKids.TabIndex = 0;
            // 
            // btClone
            // 
            this.btClone.Location = new System.Drawing.Point(173, 60);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(57, 26);
            this.btClone.TabIndex = 2;
            this.btClone.Text = "-->";
            this.btClone.Click += new System.EventHandler(this.btClone_Click);
            // 
            // lsNewKids
            // 
            this.lsNewKids.ItemHeight = 12;
            this.lsNewKids.Location = new System.Drawing.Point(250, 26);
            this.lsNewKids.Name = "lsNewKids";
            this.lsNewKids.Size = new System.Drawing.Size(211, 172);
            this.lsNewKids.TabIndex = 1;
            // 
            // putBack
            // 
            this.putBack.Location = new System.Drawing.Point(173, 112);
            this.putBack.Name = "putBack";
            this.putBack.Size = new System.Drawing.Size(57, 26);
            this.putBack.TabIndex = 3;
            this.putBack.Text = "<--";
            this.putBack.Click += new System.EventHandler(this.putBack_Click);
            // 
            // m_lsNewKids
            // 
            this.m_lsNewKids.FormattingEnabled = true;
            this.m_lsNewKids.ItemHeight = 12;
            this.m_lsNewKids.Location = new System.Drawing.Point(14, 216);
            this.m_lsNewKids.Name = "m_lsNewKids";
            this.m_lsNewKids.Size = new System.Drawing.Size(153, 160);
            this.m_lsNewKids.TabIndex = 4;
            // 
            // m_lsKids
            // 
            this.m_lsKids.FormattingEnabled = true;
            this.m_lsKids.ItemHeight = 12;
            this.m_lsKids.Location = new System.Drawing.Point(250, 216);
            this.m_lsKids.Name = "m_lsKids";
            this.m_lsKids.Size = new System.Drawing.Size(211, 160);
            this.m_lsKids.TabIndex = 5;
            // 
            // dGrid
            // 
            this.dGrid.CaptionVisible = false;
            this.dGrid.DataMember = "";
            this.dGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dGrid.Location = new System.Drawing.Point(501, 26);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(200, 172);
            this.dGrid.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(617, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(757, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_lsKids);
            this.Controls.Add(this.m_lsNewKids);
            this.Controls.Add(this.putBack);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.lsNewKids);
            this.Controls.Add(this.lsKids);
            this.Controls.Add(this.dGrid);
            this.Name = "Form1";
            this.Text = "List adapter";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdapterForm());
		}

		private void btClone_Click(object sender, EventArgs e) {
			int i = lskids.SelectedIndex ();
			if( i >= 0) {
				Swimmer sw = swdata.getSwimmer (i);
				lsnewKids.Add (sw.getName() +"\t"+sw.getTime ());
                m_lsNewKids.Add(sw);
                m_lsNewGridKids.Add(sw);
                m_lsKids.clearSelection();
				lskids.clearSelection ();
			}
		}

		private void btBack_Click(object sender, System.EventArgs e) {
			reload();
		}

		private void putBack_Click(object sender, EventArgs e) {
			int i = lsnewKids.SelectedIndex ();
			if(i >= 0)
				lsNewKids.Items.RemoveAt (i); 
		}
	}
}
