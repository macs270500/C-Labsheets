namespace Lab6Q4
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
            this.txtHrsWorked = new System.Windows.Forms.TextBox();
            this.LblHrsWorked = new System.Windows.Forms.Label();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.LblHOurlyPay = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.LblGrossPay = new System.Windows.Forms.Label();
            this.btnGrossPay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHrsWorked
            // 
            this.txtHrsWorked.Location = new System.Drawing.Point(162, 40);
            this.txtHrsWorked.Name = "txtHrsWorked";
            this.txtHrsWorked.Size = new System.Drawing.Size(187, 20);
            this.txtHrsWorked.TabIndex = 0;
            // 
            // LblHrsWorked
            // 
            this.LblHrsWorked.AutoSize = true;
            this.LblHrsWorked.Location = new System.Drawing.Point(30, 43);
            this.LblHrsWorked.Name = "LblHrsWorked";
            this.LblHrsWorked.Size = new System.Drawing.Size(126, 13);
            this.LblHrsWorked.TabIndex = 1;
            this.LblHrsWorked.Text = "Number of hours worked:";
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(162, 74);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(186, 20);
            this.txtHourlyPay.TabIndex = 2;
            // 
            // LblHOurlyPay
            // 
            this.LblHOurlyPay.AutoSize = true;
            this.LblHOurlyPay.Location = new System.Drawing.Point(75, 77);
            this.LblHOurlyPay.Name = "LblHOurlyPay";
            this.LblHOurlyPay.Size = new System.Drawing.Size(81, 13);
            this.LblHOurlyPay.TabIndex = 3;
            this.LblHOurlyPay.Text = "Hourly pay rate:";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(162, 169);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(186, 20);
            this.txtGrossPay.TabIndex = 4;
            // 
            // LblGrossPay
            // 
            this.LblGrossPay.AutoSize = true;
            this.LblGrossPay.Location = new System.Drawing.Point(63, 172);
            this.LblGrossPay.Name = "LblGrossPay";
            this.LblGrossPay.Size = new System.Drawing.Size(93, 13);
            this.LblGrossPay.TabIndex = 5;
            this.LblGrossPay.Text = "Gross pay earned:";
            // 
            // btnGrossPay
            // 
            this.btnGrossPay.Location = new System.Drawing.Point(33, 214);
            this.btnGrossPay.Name = "btnGrossPay";
            this.btnGrossPay.Size = new System.Drawing.Size(121, 41);
            this.btnGrossPay.TabIndex = 6;
            this.btnGrossPay.Text = "Calculate gross pay";
            this.btnGrossPay.UseVisualStyleBackColor = true;
            this.btnGrossPay.Click += new System.EventHandler(this.BtnGrossPay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(220, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 39);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 283);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGrossPay);
            this.Controls.Add(this.LblGrossPay);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.LblHOurlyPay);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.LblHrsWorked);
            this.Controls.Add(this.txtHrsWorked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHrsWorked;
        private System.Windows.Forms.Label LblHrsWorked;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.Label LblHOurlyPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label LblGrossPay;
        private System.Windows.Forms.Button btnGrossPay;
        private System.Windows.Forms.Button btnClose;
    }
}

