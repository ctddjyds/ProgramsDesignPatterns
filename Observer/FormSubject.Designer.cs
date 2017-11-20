namespace Observer
{
    partial class FormSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opBlue = new System.Windows.Forms.RadioButton();
            this.opGreen = new System.Windows.Forms.RadioButton();
            this.opRed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opBlue);
            this.groupBox1.Controls.Add(this.opGreen);
            this.groupBox1.Controls.Add(this.opRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select colors";
            // 
            // opBlue
            // 
            this.opBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opBlue.ForeColor = System.Drawing.Color.Blue;
            this.opBlue.Location = new System.Drawing.Point(38, 95);
            this.opBlue.Name = "opBlue";
            this.opBlue.Size = new System.Drawing.Size(96, 17);
            this.opBlue.TabIndex = 2;
            this.opBlue.Text = "Blue";
            // 
            // opGreen
            // 
            this.opGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.opGreen.Location = new System.Drawing.Point(38, 69);
            this.opGreen.Name = "opGreen";
            this.opGreen.Size = new System.Drawing.Size(116, 17);
            this.opGreen.TabIndex = 1;
            this.opGreen.Text = "Green";
            // 
            // opRed
            // 
            this.opRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opRed.ForeColor = System.Drawing.Color.Red;
            this.opRed.Location = new System.Drawing.Point(38, 34);
            this.opRed.Name = "opRed";
            this.opRed.Size = new System.Drawing.Size(125, 26);
            this.opRed.TabIndex = 0;
            this.opRed.Text = "Red";
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSubject";
            this.Text = "Subject Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opBlue;
        private System.Windows.Forms.RadioButton opGreen;
        private System.Windows.Forms.RadioButton opRed;
    }
}