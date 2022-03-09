namespace Benefits_menu
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
            this.chkDrug = new System.Windows.Forms.CheckBox();
            this.chkDental = new System.Windows.Forms.CheckBox();
            this.chkVision = new System.Windows.Forms.CheckBox();
            this.chkMedical = new System.Windows.Forms.CheckBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkDrug
            // 
            this.chkDrug.AutoSize = true;
            this.chkDrug.Location = new System.Drawing.Point(40, 24);
            this.chkDrug.Name = "chkDrug";
            this.chkDrug.Size = new System.Drawing.Size(173, 17);
            this.chkDrug.TabIndex = 0;
            this.chkDrug.Text = "Prescription Drug Plan ($39.15)";
            this.chkDrug.UseVisualStyleBackColor = true;
            // 
            // chkDental
            // 
            this.chkDental.AutoSize = true;
            this.chkDental.Location = new System.Drawing.Point(40, 47);
            this.chkDental.Name = "chkDental";
            this.chkDental.Size = new System.Drawing.Size(123, 17);
            this.chkDental.TabIndex = 1;
            this.chkDental.Text = "Dental Plan ($10.81)";
            this.chkDental.UseVisualStyleBackColor = true;
            // 
            // chkVision
            // 
            this.chkVision.AutoSize = true;
            this.chkVision.Location = new System.Drawing.Point(40, 71);
            this.chkVision.Name = "chkVision";
            this.chkVision.Size = new System.Drawing.Size(114, 17);
            this.chkVision.TabIndex = 2;
            this.chkVision.Text = "Vision Plan ($2.25)";
            this.chkVision.UseVisualStyleBackColor = true;
            // 
            // chkMedical
            // 
            this.chkMedical.AutoSize = true;
            this.chkMedical.Location = new System.Drawing.Point(40, 95);
            this.chkMedical.Name = "chkMedical";
            this.chkMedical.Size = new System.Drawing.Size(129, 17);
            this.chkMedical.TabIndex = 3;
            this.chkMedical.Text = "Medical Plan ($55.52)";
            this.chkMedical.UseVisualStyleBackColor = true;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(40, 129);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(195, 48);
            this.btnDetermine.TabIndex = 4;
            this.btnDetermine.Text = "Determine Monthly Cost";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(152, 197);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(48, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Monthly Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 245);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.chkMedical);
            this.Controls.Add(this.chkVision);
            this.Controls.Add(this.chkDental);
            this.Controls.Add(this.chkDrug);
            this.Name = "Form1";
            this.Text = "Benefits Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDrug;
        private System.Windows.Forms.CheckBox chkDental;
        private System.Windows.Forms.CheckBox chkVision;
        private System.Windows.Forms.CheckBox chkMedical;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

