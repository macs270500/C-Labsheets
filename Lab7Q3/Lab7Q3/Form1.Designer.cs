namespace Lab7Q3
{
    partial class Form1
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
            this.chkRiot = new System.Windows.Forms.CheckBox();
            this.chkTheft = new System.Windows.Forms.CheckBox();
            this.chkFire = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.lblPremium = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRiot
            // 
            this.chkRiot.AutoSize = true;
            this.chkRiot.Location = new System.Drawing.Point(22, 30);
            this.chkRiot.Name = "chkRiot";
            this.chkRiot.Size = new System.Drawing.Size(94, 17);
            this.chkRiot.TabIndex = 0;
            this.chkRiot.Text = "Riot (Rs 2000)";
            this.chkRiot.UseVisualStyleBackColor = true;
            // 
            // chkTheft
            // 
            this.chkTheft.AutoSize = true;
            this.chkTheft.Location = new System.Drawing.Point(22, 53);
            this.chkTheft.Name = "chkTheft";
            this.chkTheft.Size = new System.Drawing.Size(100, 17);
            this.chkTheft.TabIndex = 1;
            this.chkTheft.Text = "Theft (Rs 4500)";
            this.chkTheft.UseVisualStyleBackColor = true;
            // 
            // chkFire
            // 
            this.chkFire.AutoSize = true;
            this.chkFire.Location = new System.Drawing.Point(22, 76);
            this.chkFire.Name = "chkFire";
            this.chkFire.Size = new System.Drawing.Size(92, 17);
            this.chkFire.TabIndex = 2;
            this.chkFire.Text = "Fire (Rs 3750)";
            this.chkFire.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFire);
            this.groupBox1.Controls.Add(this.chkTheft);
            this.groupBox1.Controls.Add(this.chkRiot);
            this.groupBox1.Location = new System.Drawing.Point(68, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Benefits";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(128, 23);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(102, 20);
            this.txtSum.TabIndex = 4;
            
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(53, 26);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(69, 13);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Sum Insured:";
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(128, 266);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.ReadOnly = true;
            this.txtPremium.Size = new System.Drawing.Size(101, 20);
            this.txtPremium.TabIndex = 7;
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new System.Drawing.Point(65, 269);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(50, 13);
            this.lblPremium.TabIndex = 8;
            this.lblPremium.Text = "Premium:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 311);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Comprehensive Car Cover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRiot;
        private System.Windows.Forms.CheckBox chkTheft;
        private System.Windows.Forms.CheckBox chkFire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.Label lblPremium;
    }
}

     

