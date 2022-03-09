namespace Assignment
{
    partial class Employee_Management
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtSalaryperHr = new System.Windows.Forms.TextBox();
            this.txtSalaryperDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaryperDay = new System.Windows.Forms.Label();
            this.cmbEmpId = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnDetailedView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(120, 113);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(121, 20);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.TabStop = false;
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Location = new System.Drawing.Point(120, 142);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(121, 20);
            this.txtTimeIn.TabIndex = 2;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(120, 171);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(121, 20);
            this.txtTimeOut.TabIndex = 3;
            // 
            // txtSalaryperHr
            // 
            this.txtSalaryperHr.Location = new System.Drawing.Point(120, 229);
            this.txtSalaryperHr.Name = "txtSalaryperHr";
            this.txtSalaryperHr.Size = new System.Drawing.Size(121, 20);
            this.txtSalaryperHr.TabIndex = 5;
            this.txtSalaryperHr.TabStop = false;
            // 
            // txtSalaryperDay
            // 
            this.txtSalaryperDay.Location = new System.Drawing.Point(120, 258);
            this.txtSalaryperDay.Name = "txtSalaryperDay";
            this.txtSalaryperDay.ReadOnly = true;
            this.txtSalaryperDay.Size = new System.Drawing.Size(121, 20);
            this.txtSalaryperDay.TabIndex = 6;
            this.txtSalaryperDay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Time IN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Time OUT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salary per Hour:";
            // 
            // SalaryperDay
            // 
            this.SalaryperDay.AutoSize = true;
            this.SalaryperDay.Location = new System.Drawing.Point(28, 261);
            this.SalaryperDay.Name = "SalaryperDay";
            this.SalaryperDay.Size = new System.Drawing.Size(79, 13);
            this.SalaryperDay.TabIndex = 17;
            this.SalaryperDay.Text = "Salary per Day:";
            // 
            // cmbEmpId
            // 
            this.cmbEmpId.FormattingEnabled = true;
            this.cmbEmpId.Location = new System.Drawing.Point(120, 83);
            this.cmbEmpId.Name = "cmbEmpId";
            this.cmbEmpId.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpId.TabIndex = 0;
            this.cmbEmpId.SelectedIndexChanged += new System.EventHandler(this.cmbEmpId_SelectedIndexChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(275, 82);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(91, 23);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Process ";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnDetailedView
            // 
            this.btnDetailedView.Location = new System.Drawing.Point(275, 139);
            this.btnDetailedView.Name = "btnDetailedView";
            this.btnDetailedView.Size = new System.Drawing.Size(91, 23);
            this.btnDetailedView.TabIndex = 8;
            this.btnDetailedView.Text = "DetailedView";
            this.btnDetailedView.UseVisualStyleBackColor = true;
            this.btnDetailedView.Click += new System.EventHandler(this.btnDetailedView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(120, 200);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(121, 20);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Category:";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(275, 196);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 58);
            this.label7.TabIndex = 18;
            this.label7.Text = "Employee Management";
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 298);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDetailedView);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cmbEmpId);
            this.Controls.Add(this.SalaryperDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalaryperDay);
            this.Controls.Add(this.txtSalaryperHr);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.txtEmpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            this.Load += new System.EventHandler(this.Employee_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.TextBox txtSalaryperHr;
        private System.Windows.Forms.TextBox txtSalaryperDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SalaryperDay;
        private System.Windows.Forms.ComboBox cmbEmpId;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnDetailedView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label7;
    }
}