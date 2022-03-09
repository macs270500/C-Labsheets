namespace Lab6Q1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.LblNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLargerNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(134, 61);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(85, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(44, 64);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(84, 13);
            this.LblNum1.TabIndex = 1;
            this.LblNum1.Text = "Enter Number 1:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(134, 100);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(85, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(44, 103);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(84, 13);
            this.LblNum2.TabIndex = 3;
            this.LblNum2.Text = "Enter Number 2:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(61, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 31);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate larger number ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtLargerNum
            // 
            this.txtLargerNum.Location = new System.Drawing.Point(47, 213);
            this.txtLargerNum.Name = "txtLargerNum";
            this.txtLargerNum.ReadOnly = true;
            this.txtLargerNum.Size = new System.Drawing.Size(171, 20);
            this.txtLargerNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 287);
            this.Controls.Add(this.txtLargerNum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.LblNum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLargerNum;
    }
}

