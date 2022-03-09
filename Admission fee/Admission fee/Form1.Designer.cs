namespace Admission_fee
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
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radMinor = new System.Windows.Forms.RadioButton();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radSenoir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.LblFee = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(6, 19);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(65, 17);
            this.radChild.TabIndex = 0;
            this.radChild.TabStop = true;
            this.radChild.Text = "child(<6)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radMinor
            // 
            this.radMinor.AutoSize = true;
            this.radMinor.Location = new System.Drawing.Point(6, 42);
            this.radMinor.Name = "radMinor";
            this.radMinor.Size = new System.Drawing.Size(80, 17);
            this.radMinor.TabIndex = 1;
            this.radMinor.TabStop = true;
            this.radMinor.Text = "minor (6-17)";
            this.radMinor.UseVisualStyleBackColor = true;
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(6, 65);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(84, 17);
            this.radAdult.TabIndex = 2;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "adult (18-64)";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radSenoir
            // 
            this.radSenoir.AutoSize = true;
            this.radSenoir.Location = new System.Drawing.Point(6, 88);
            this.radSenoir.Name = "radSenoir";
            this.radSenoir.Size = new System.Drawing.Size(80, 17);
            this.radSenoir.TabIndex = 3;
            this.radSenoir.TabStop = true;
            this.radSenoir.Text = "senior (65+)";
            this.radSenoir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSenoir);
            this.groupBox1.Controls.Add(this.radAdult);
            this.groupBox1.Controls.Add(this.radMinor);
            this.groupBox1.Controls.Add(this.radChild);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Age";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(149, 41);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(128, 41);
            this.btnDetermine.TabIndex = 5;
            this.btnDetermine.Text = "Determine Fee";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(199, 119);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(64, 20);
            this.txtFee.TabIndex = 6;
            // 
            // LblFee
            // 
            this.LblFee.AutoSize = true;
            this.LblFee.Location = new System.Drawing.Point(165, 124);
            this.LblFee.Name = "LblFee";
            this.LblFee.Size = new System.Drawing.Size(28, 13);
            this.LblFee.TabIndex = 7;
            this.LblFee.Text = "Fee:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 225);
            this.Controls.Add(this.LblFee);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Admisson Fee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radMinor;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radSenoir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label LblFee;
    }
}

