using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SlashDecorator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class DecoratorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btQuit;
		private System.Windows.Forms.Button btButtonA;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public DecoratorForm()
		{			
			InitializeComponent();
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
            this.btButtonA = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btButtonA
            // 
            this.btButtonA.Location = new System.Drawing.Point(12, 154);
            this.btButtonA.Name = "btButtonA";
            this.btButtonA.Size = new System.Drawing.Size(96, 28);
            this.btButtonA.TabIndex = 1;
            this.btButtonA.Text = "Not Decorator";
            this.btButtonA.Click += new System.EventHandler(this.btButtonA_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(241, 199);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(57, 28);
            this.btQuit.TabIndex = 0;
            this.btQuit.Text = "Quit";
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 136);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dark Roast";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Not Decorator";
            // 
            // DecoratorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(329, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btButtonA);
            this.Controls.Add(this.btQuit);
            this.Name = "DecoratorForm";
            this.Text = "Cool Decorator";
            this.ResumeLayout(false);

		}
		#endregion


		private void btQuit_Click(object sender, System.EventArgs e)
        {
			this.Close ();
		}

		private void btButtonA_Click(object sender, System.EventArgs e)
        {
            Beverage bevarage = new EspressoBeverage();
            this.richTextBox1.Text = string.Format("{0},${1}", bevarage.GetDescription(), bevarage.cost());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beverage bevarage = new DarkRoastBeverage();
            bevarage = new MochaDecorator(bevarage);//ÓÃmocha×°ÊÎ
            bevarage = new MochaDecorator(bevarage);
            bevarage = new WhipDecorator(bevarage);
            this.richTextBox1.Text = string.Format("{0},${1}", bevarage.GetDescription(), bevarage.cost());
        }
    }
}
