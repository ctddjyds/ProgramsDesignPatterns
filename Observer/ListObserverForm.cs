using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Observer
{
	/// <summary>
	/// Summary description for ListObs.
	/// </summary>
	public class ListObserverForm : System.Windows.Forms.Form, IObserver
	{
		private System.Windows.Forms.ListBox lsColors;
		/// <summary>
		/// Adds text of color to list box
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ListObserverForm()
        {
			InitializeComponent();
		}
		//------
		public void Update(string message)
        {
			lsColors.Items.Add(message);
            if (!this.IsDisposed)
                this.Show();
        }
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.lsColors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsColors
            // 
            this.lsColors.ItemHeight = 12;
            this.lsColors.Location = new System.Drawing.Point(19, 17);
            this.lsColors.Name = "lsColors";
            this.lsColors.Size = new System.Drawing.Size(259, 184);
            this.lsColors.TabIndex = 0;
            // 
            // ListObs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(294, 219);
            this.Controls.Add(this.lsColors);
            this.Name = "ListObs";
            this.Text = "List observer";
            this.ResumeLayout(false);

		}
		#endregion
	}
}
