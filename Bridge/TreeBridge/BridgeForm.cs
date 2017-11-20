using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CsharpPats;

namespace BasicBridge
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class BridgeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lsProd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ArrayList products;
		private IVistList prodList, treeList,gridList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView treeProd;
        private DataGrid grdProd;
        private System.Windows.Forms.Label label2;
	
		public BridgeForm() 		{
			InitializeComponent();
			init();
		}
		private void init()
        {
			products = new ArrayList ();
			readFile(products);	//read in the data file
			//create the product list 
			prodList = new ProductList (lsProd);
			//Bridge to product VisList
			IBridger lbr = new SortBridge (prodList);
			//put the data into the product list
			lbr.addData (products);
			//create the grid VisList
			treeList = new TreeList(treeProd);
			//Bridge to the grid list
			IBridger tbr = new SortBridge (treeList);
            gridList = new GridList(grdProd);
            //Bridge to the grid list
            IBridger gbr = new ListBridge(gridList);
            //put the data into the grid display
            tbr.addData(products);
            gbr.addData (products);
		}
		private void readFile(ArrayList products)
        {
			csFile fl = new csFile("products.txt");
			fl.OpenForRead ();
			string s = fl.readLine ();
			while(s != null ) {
				Product p = new Product(s);
				products.Add (p);
				s = fl.readLine ();
			}
		    fl.close();
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
            this.lsProd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeProd = new System.Windows.Forms.TreeView();
            this.grdProd = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grdProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lsProd
            // 
            this.lsProd.ItemHeight = 12;
            this.lsProd.Location = new System.Drawing.Point(19, 43);
            this.lsProd.Name = "lsProd";
            this.lsProd.Size = new System.Drawing.Size(154, 184);
            this.lsProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer view";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(230, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Executive view";
            // 
            // treeProd
            // 
            this.treeProd.Location = new System.Drawing.Point(221, 52);
            this.treeProd.Name = "treeProd";
            this.treeProd.Size = new System.Drawing.Size(182, 172);
            this.treeProd.TabIndex = 4;
            // 
            // grdProd
            // 
            this.grdProd.CaptionVisible = false;
            this.grdProd.DataMember = "";
            this.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdProd.Location = new System.Drawing.Point(19, 248);
            this.grdProd.Name = "grdProd";
            this.grdProd.RowHeadersVisible = false;
            this.grdProd.Size = new System.Drawing.Size(192, 190);
            this.grdProd.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(498, 496);
            this.Controls.Add(this.grdProd);
            this.Controls.Add(this.treeProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsProd);
            this.Name = "Form1";
            this.Text = "Sorted bridge";
            ((System.ComponentModel.ISupportInitialize)(this.grdProd)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new BridgeForm());
		}
	}
}
