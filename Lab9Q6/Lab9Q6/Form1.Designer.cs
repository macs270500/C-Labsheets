namespace Lab9Q6
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstPresidents = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "US Presidential Search";
            // 
            // lstPresidents
            // 
            this.lstPresidents.FormattingEnabled = true;
            this.lstPresidents.Items.AddRange(new object[] {
            "Abraham Lincoln",
            "Andrew Jackson",
            "Andrew Johnson",
            "Barack Obama",
            "Benjamin Harrison",
            "Bill Clinton",
            "Calvin Coolidge",
            "Chester A. Arthur",
            "Donald Trump",
            "Dwight D. Eisenhower",
            "Franklin D. Roosevelt",
            "Franklin Pierce",
            "George H. W. Bush",
            "George W. Bush",
            "George Washington",
            "Gerald Ford",
            "Grover Cleveland",
            "Grover Cleveland",
            "Harry S. Truman",
            "Herbert Hoover",
            "James A. Garfield",
            "James Buchanan",
            "James K. Polk",
            "James Madison",
            "James Monroe",
            "Jimmy Carter",
            "John Adams",
            "John F. Kennedy",
            "John Q. Adams",
            "John Tyler",
            "Lyndon B. Johnson",
            "Martin Van Buren",
            "Millard Fillmore",
            "Richard Nixon",
            "Ronald Reagan",
            "Rutherford B. Hayes",
            "Theodore Roosevelt",
            "Thomas Jefferson",
            "Ulysses S. Grant",
            "Warren G. Harding",
            "William H. Harrison",
            "William H. Taft",
            "William McKinley",
            "Woodrow Wilson",
            "Zachary Taylor"});
            this.lstPresidents.Location = new System.Drawing.Point(46, 83);
            this.lstPresidents.Name = "lstPresidents";
            this.lstPresidents.Size = new System.Drawing.Size(195, 264);
            this.lstPresidents.Sorted = true;
            this.lstPresidents.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(313, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(284, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 393);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstPresidents);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPresidents;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}

