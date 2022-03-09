namespace Lab9Q4
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
            this.lstStates = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lstLastTen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStates
            // 
            this.lstStates.FormattingEnabled = true;
            this.lstStates.Items.AddRange(new object[] {
            "Delaware",
            "Pennsylvania",
            "New Jersey",
            "Georgia",
            "Connecticut",
            "Massachusetts",
            "Maryland",
            "South Carolina",
            "New Hampshire",
            "Virginia",
            "New York",
            "North Carolina",
            "Rhode Island",
            "Vermont",
            "Kentucky",
            "Tennessee",
            "Ohio",
            "Louisiana",
            "Indiana",
            "Mississippi",
            "Illinois",
            "Alabama",
            "Maine",
            "Missouri",
            "Arkansas",
            "Michigan",
            "Florida",
            "Texas",
            "Iowa",
            "Wisconsin",
            "California",
            "Minnesota",
            "Oregon",
            "Kansas",
            "West Virginia",
            "Nevada",
            "Nebraska",
            "Colorado",
            "North Dakota",
            "South Dakota",
            "Montana",
            "Washington",
            "Idaho",
            "Wyoming",
            "Utah",
            "Oklahoma",
            "New Mexico",
            "Arizona",
            "Alaska",
            "Hawaii "});
            this.lstStates.Location = new System.Drawing.Point(15, 26);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(193, 355);
            this.lstStates.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(235, 28);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(140, 57);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Display Last Ten States";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lstLastTen
            // 
            this.lstLastTen.FormattingEnabled = true;
            this.lstLastTen.Location = new System.Drawing.Point(235, 103);
            this.lstLastTen.Name = "lstLastTen";
            this.lstLastTen.Size = new System.Drawing.Size(140, 277);
            this.lstLastTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "States:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLastTen);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstStates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStates;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lstLastTen;
        private System.Windows.Forms.Label label1;
    }
}

