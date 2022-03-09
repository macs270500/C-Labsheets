namespace Lab10Q3
{
    partial class frmSources
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtxtWages = new System.Windows.Forms.MaskedTextBox();
            this.mtxtInterest = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDividened = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(63, 207);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(130, 23);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute Total  Income";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 33);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // mtxtWages
            // 
            this.mtxtWages.HidePromptOnLeave = true;
            this.mtxtWages.Location = new System.Drawing.Point(132, 74);
            this.mtxtWages.Mask = "##########";
            this.mtxtWages.Name = "mtxtWages";
            this.mtxtWages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtWages.Size = new System.Drawing.Size(100, 20);
            this.mtxtWages.TabIndex = 2;
            // 
            // mtxtInterest
            // 
            this.mtxtInterest.HidePromptOnLeave = true;
            this.mtxtInterest.Location = new System.Drawing.Point(132, 115);
            this.mtxtInterest.Mask = "##########";
            this.mtxtInterest.Name = "mtxtInterest";
            this.mtxtInterest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtInterest.Size = new System.Drawing.Size(100, 20);
            this.mtxtInterest.TabIndex = 3;
            this.mtxtInterest.ValidatingType = typeof(int);
            // 
            // mtxtDividened
            // 
            this.mtxtDividened.HidePromptOnLeave = true;
            this.mtxtDividened.Location = new System.Drawing.Point(132, 156);
            this.mtxtDividened.Mask = "##########";
            this.mtxtDividened.Name = "mtxtDividened";
            this.mtxtDividened.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtDividened.Size = new System.Drawing.Size(100, 20);
            this.mtxtDividened.TabIndex = 4;
            this.mtxtDividened.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interest Income:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dividened Income:";
            // 
            // frmSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtDividened);
            this.Controls.Add(this.mtxtInterest);
            this.Controls.Add(this.mtxtWages);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCompute);
            this.Name = "frmSources";
            this.Text = "Sources of Income";
            this.Load += new System.EventHandler(this.frmSources_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtxtWages;
        private System.Windows.Forms.MaskedTextBox mtxtInterest;
        private System.Windows.Forms.MaskedTextBox mtxtDividened;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}