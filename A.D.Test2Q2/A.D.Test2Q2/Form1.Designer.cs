namespace A.D.Test2Q2
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(219, 104);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Items.AddRange(new object[] {
            "45",
            "29",
            "81",
            "76",
            "54",
            "31",
            "66",
            "15",
            "69",
            "27",
            "41",
            "88",
            "33",
            "90",
            "85",
            "74",
            "84",
            "10"});
            this.lstMarks.Location = new System.Drawing.Point(19, 58);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(137, 173);
            this.lstMarks.TabIndex = 1;
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(189, 136);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(120, 95);
            this.lstList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Highest Marks (n):";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(174, 78);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(120, 20);
            this.txtN.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 259);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "CSE1028Y Marks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
    }
}

