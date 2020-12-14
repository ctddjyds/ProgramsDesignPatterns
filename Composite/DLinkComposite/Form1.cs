using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Composite
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label lbSalary;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		IEmployee prez, marketVP, salesMgr;
		TreeNode rootNode;
		IEmployee advMgr, emp, prodVP, prodMgr, shipMgr;
		private System.Windows.Forms.TreeView EmpTree;
		private System.Windows.Forms.Button btShowBoss;
		private Random rand;
	
		private void init() 
		{
			rand = new Random ();
			buildEmployeeList();
			buildTree();
		}
		//---------------
		private void buildEmployeeList() 
		{
			prez = new Boss(null, "CEO", 200000);
			marketVP = new Boss(prez, "Marketing VP", 100000);
			prez.add(marketVP);
			salesMgr = new Boss(marketVP,"Sales Mgr", 50000);
			advMgr = new Boss(marketVP,"Advt Mgr", 50000);
			marketVP.add(salesMgr);
			marketVP.add(advMgr);
			prodVP = new Boss(prez, "Production VP", 100000);
			prez.add(prodVP);
			advMgr.add("Secy", 20000);

			//add salesmen reporting to sales manager
			for (int i = 1; i<=5; i++)
			{
				salesMgr.add("Sales" + i.ToString(), rand_sal(30000));
			}

			prodMgr = new Boss(prodVP, "Prod Mgr", 40000);
			shipMgr = new Boss(prodVP, "Ship Mgr", 35000);
			prodVP.add(prodMgr);
			prodVP.add(shipMgr);

			for (int i = 1; i<=3; i++)
			{
				shipMgr.add("Ship" + i.ToString(), rand_sal(25000));
			}
			for (int i = 1; i<=4; i++)
			{
				prodMgr.add("Manuf" + i.ToString(), rand_sal(20000));
			}
		}
		//-----
		private void buildTree() 
		{
			EmpNode nod;

			nod = new EmpNode(prez);
			rootNode = nod;
			EmpTree.Nodes.Add(nod);
			addNodes(nod, prez);
		}
		
		//------
		private void getNodeSum(EmpNode node) 
		{
			IEmployee emp;
			float sum;

			emp = node.getEmployee();
			sum = emp.getSalaries();
			lbSalary.Text = sum.ToString ();
		}
		//------
		private void addNodes(EmpNode nod, IEmployee emp) 
		{
			IEmployee newEmp;
			EmpNode newNode;
			IEnumerator empEnum;
			empEnum = emp.getSubordinates();

			while (empEnum.MoveNext()) 
			{
				newEmp = (IEmployee)empEnum.Current;
				newNode = new EmpNode(newEmp);
				nod.Nodes.Add(newNode);
				addNodes(newNode, newEmp);
		    }
		}
		//------
		private float rand_sal(float sal) 
		{
			float rnum = rand.Next ();
			rnum = rnum / Int32.MaxValue;
			return rnum * sal / 5 + sal;
		}
		//------
		public Form1() 
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
            this.lbSalary = new System.Windows.Forms.Label();
            this.EmpTree = new System.Windows.Forms.TreeView();
            this.btShowBoss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSalary
            // 
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(128, 336);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(304, 39);
            this.lbSalary.TabIndex = 1;
            // 
            // EmpTree
            // 
            this.EmpTree.Location = new System.Drawing.Point(63, 39);
            this.EmpTree.Name = "EmpTree";
            this.EmpTree.Size = new System.Drawing.Size(449, 271);
            this.EmpTree.TabIndex = 0;
            this.EmpTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EmpTree_AfterSelect);
            // 
            // btShowBoss
            // 
            this.btShowBoss.Location = new System.Drawing.Point(192, 387);
            this.btShowBoss.Name = "btShowBoss";
            this.btShowBoss.Size = new System.Drawing.Size(145, 39);
            this.btShowBoss.TabIndex = 2;
            this.btShowBoss.Text = "Show boss";
            this.btShowBoss.Click += new System.EventHandler(this.btShowBoss_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(569, 456);
            this.Controls.Add(this.btShowBoss);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.EmpTree);
            this.Name = "Form1";
            this.Text = "Basic composite";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void EmpTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
			EmpNode node;
			node = (EmpNode)EmpTree.SelectedNode;
			getNodeSum(node);
		}

		private void btShowBoss_Click(object sender, System.EventArgs e)
        {
			EmpNode node;
			node = (EmpNode)EmpTree.SelectedNode;
			IEmployee emp = node.getEmployee ();
			string bosses = "";
			while(emp != null) 
			{
                bosses += emp.getName () +"\n";
				emp = emp.getBoss();
			}
			MessageBox.Show (null, bosses,"Reporting chain");
	    }
	}
}
