namespace Assignment
{
    partial class EmpDetailedView
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
            this.EmplistView = new System.Windows.Forms.ListView();
            this.EmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalaryperHr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalaryperDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmplistView
            // 
            this.EmplistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Category,
            this.SalaryperHr,
            this.SalaryperDay});
            this.EmplistView.FullRowSelect = true;
            this.EmplistView.HideSelection = false;
            this.EmplistView.Location = new System.Drawing.Point(12, 12);
            this.EmplistView.Name = "EmplistView";
            this.EmplistView.Size = new System.Drawing.Size(625, 237);
            this.EmplistView.TabIndex = 0;
            this.EmplistView.UseCompatibleStateImageBehavior = false;
            this.EmplistView.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "EmployeeID";
            this.EmployeeId.Width = 80;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Employee Name";
            this.EmployeeName.Width = 162;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 143;
            // 
            // SalaryperHr
            // 
            this.SalaryperHr.Text = "Salary/Hour";
            this.SalaryperHr.Width = 105;
            // 
            // SalaryperDay
            // 
            this.SalaryperDay.Text = "Salary/Day";
            this.SalaryperDay.Width = 131;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(89, 279);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(287, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmpDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 329);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.EmplistView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpDetailedView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpDetailedView";
            this.Load += new System.EventHandler(this.EmpDetailedView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmplistView;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader EmployeeId;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader SalaryperHr;
        private System.Windows.Forms.ColumnHeader SalaryperDay;
    }
}