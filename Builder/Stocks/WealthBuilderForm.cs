using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

/// <summary>
/// Summary description for Form1.
/// </summary>
public class WealthBuilderForm : Form
{
	private ListBox lsEquities;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private Container components = null;
	private Button btPlot;
	private Panel pnl;
	private IChoiceBuilder mchoice;
	private void init()
    {
		lsEquities.Items.Add (new StocksEquities());
		lsEquities.Items.Add (new BondsEquities());
		lsEquities.Items.Add (new MutualsEquities());
	}
	public WealthBuilderForm()
	{
		InitializeComponent();
		init();
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
	private void setPanel()
    {
     	pnl.Location = new Point(152, 24);
		pnl.Size = new Size(128, 168);
		pnl.TabIndex = 1;
		Controls.Add(pnl);
	}


	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
            this.lsEquities = new System.Windows.Forms.ListBox();
            this.btPlot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsEquities
            // 
            this.lsEquities.ItemHeight = 18;
            this.lsEquities.Location = new System.Drawing.Point(20, 18);
            this.lsEquities.Name = "lsEquities";
            this.lsEquities.Size = new System.Drawing.Size(360, 166);
            this.lsEquities.TabIndex = 0;
            this.lsEquities.SelectedIndexChanged += new System.EventHandler(this.lsEquities_SelectedIndexChanged);
            // 
            // btPlot
            // 
            this.btPlot.Location = new System.Drawing.Point(220, 226);
            this.btPlot.Name = "btPlot";
            this.btPlot.Size = new System.Drawing.Size(128, 40);
            this.btPlot.TabIndex = 1;
            this.btPlot.Text = "Plot";
            this.btPlot.Click += new System.EventHandler(this.btPlot_Click);
            // 
            // WealthBuilderForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(406, 289);
            this.Controls.Add(this.btPlot);
            this.Controls.Add(this.lsEquities);
            this.Name = "WealthBuilderForm";
            this.Text = "Stock analysis";
            this.ResumeLayout(false);

	}
	#endregion

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() 
	{
		Application.Run(new WealthBuilderForm());
	}

	private void lsEquities_SelectedIndexChanged(object sender, System.EventArgs e)
    {
		int i = lsEquities.SelectedIndex ;
		EquitiesAbstract eq = (EquitiesAbstract)lsEquities.Items[i];
		mchoice= DirectorFactory.GetBuilder (eq);
		this.Controls.Remove (pnl);
		pnl = mchoice.GetPanelResult ();
		setPanel();
	}

	private void btPlot_Click(object sender, System.EventArgs e)
    {
		//display the selected items in a message box
		if(mchoice != null)
        {
			ArrayList ar  = mchoice.getSelected ();
			string ans = "";
			for(int i=0; i< ar.Count ; i++)
            {
				ans += (string)ar[i] +" ";
			}
			MessageBox.Show (null, ans, "Selected equities", MessageBoxButtons.OK  );
		}
	}
}
