namespace Days_Determination_in_a_month
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
            this.LstMonths = new System.Windows.Forms.ListBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstMonths
            // 
            this.LstMonths.FormattingEnabled = true;
            this.LstMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.LstMonths.Location = new System.Drawing.Point(26, 55);
            this.LstMonths.Name = "LstMonths";
            this.LstMonths.Size = new System.Drawing.Size(102, 160);
            this.LstMonths.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(23, 26);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(81, 13);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Select a month:";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(211, 70);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(169, 40);
            this.btnDetermine.TabIndex = 2;
            this.btnDetermine.Text = "Determine Number of Days";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.BtnDetermine_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(323, 159);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(35, 20);
            this.txtDays.TabIndex = 3;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(233, 162);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(84, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Number of days:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 278);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.LstMonths);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstMonths;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
    }
}

