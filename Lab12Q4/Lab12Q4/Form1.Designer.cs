namespace Lab12Q4
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
            this.txtMark = new System.Windows.Forms.TextBox();
            this.LblMark = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.LblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(116, 50);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(149, 20);
            this.txtMark.TabIndex = 0;
            // 
            // LblMark
            // 
            this.LblMark.AutoSize = true;
            this.LblMark.Location = new System.Drawing.Point(49, 53);
            this.LblMark.Name = "LblMark";
            this.LblMark.Size = new System.Drawing.Size(61, 13);
            this.LblMark.TabIndex = 1;
            this.LblMark.Text = "Enter mark:";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(65, 127);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(167, 33);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "Calculate grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(116, 213);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(149, 20);
            this.txtGrade.TabIndex = 3;
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Location = new System.Drawing.Point(71, 216);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(39, 13);
            this.LblGrade.TabIndex = 4;
            this.LblGrade.Text = "Grade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 270);
            this.Controls.Add(this.LblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.LblMark);
            this.Controls.Add(this.txtMark);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label LblMark;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label LblGrade;
    }
}




