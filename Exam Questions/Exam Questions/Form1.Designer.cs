namespace Exam_Questions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPublic = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radStaff = new System.Windows.Forms.RadioButton();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDessert = new System.Windows.Forms.CheckBox();
            this.chkMainMeal = new System.Windows.Forms.CheckBox();
            this.chkStarter = new System.Windows.Forms.CheckBox();
            this.txtStarter = new System.Windows.Forms.TextBox();
            this.txtMainMeal = new System.Windows.Forms.TextBox();
            this.txtDessert = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPublic);
            this.groupBox1.Controls.Add(this.radStudent);
            this.groupBox1.Controls.Add(this.radStaff);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // radPublic
            // 
            this.radPublic.AutoSize = true;
            this.radPublic.Location = new System.Drawing.Point(3, 62);
            this.radPublic.Name = "radPublic";
            this.radPublic.Size = new System.Drawing.Size(54, 17);
            this.radPublic.TabIndex = 2;
            this.radPublic.TabStop = true;
            this.radPublic.Text = "Public";
            this.radPublic.UseVisualStyleBackColor = true;
            this.radPublic.CheckedChanged += new System.EventHandler(this.radPublic_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(3, 39);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 1;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radStaff
            // 
            this.radStaff.AutoSize = true;
            this.radStaff.Location = new System.Drawing.Point(3, 16);
            this.radStaff.Name = "radStaff";
            this.radStaff.Size = new System.Drawing.Size(47, 17);
            this.radStaff.TabIndex = 0;
            this.radStaff.TabStop = true;
            this.radStaff.Text = "Staff";
            this.radStaff.UseVisualStyleBackColor = true;
            this.radStaff.CheckedChanged += new System.EventHandler(this.radStaff_CheckedChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(28, 29);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(198, 31);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "UoM Cafetaria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDessert);
            this.groupBox2.Controls.Add(this.chkMainMeal);
            this.groupBox2.Controls.Add(this.chkStarter);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Item(s)";
            // 
            // chkDessert
            // 
            this.chkDessert.AutoSize = true;
            this.chkDessert.Location = new System.Drawing.Point(13, 65);
            this.chkDessert.Name = "chkDessert";
            this.chkDessert.Size = new System.Drawing.Size(62, 17);
            this.chkDessert.TabIndex = 2;
            this.chkDessert.Text = "Dessert";
            this.chkDessert.UseVisualStyleBackColor = true;
            // 
            // chkMainMeal
            // 
            this.chkMainMeal.AutoSize = true;
            this.chkMainMeal.Location = new System.Drawing.Point(13, 42);
            this.chkMainMeal.Name = "chkMainMeal";
            this.chkMainMeal.Size = new System.Drawing.Size(75, 17);
            this.chkMainMeal.TabIndex = 1;
            this.chkMainMeal.Text = "Main Meal";
            this.chkMainMeal.UseVisualStyleBackColor = true;
            // 
            // chkStarter
            // 
            this.chkStarter.AutoSize = true;
            this.chkStarter.Location = new System.Drawing.Point(13, 19);
            this.chkStarter.Name = "chkStarter";
            this.chkStarter.Size = new System.Drawing.Size(57, 17);
            this.chkStarter.TabIndex = 0;
            this.chkStarter.Text = "Starter";
            this.chkStarter.UseVisualStyleBackColor = true;
            // 
            // txtStarter
            // 
            this.txtStarter.Location = new System.Drawing.Point(124, 181);
            this.txtStarter.Name = "txtStarter";
            this.txtStarter.ReadOnly = true;
            this.txtStarter.Size = new System.Drawing.Size(102, 20);
            this.txtStarter.TabIndex = 3;
            // 
            // txtMainMeal
            // 
            this.txtMainMeal.Location = new System.Drawing.Point(124, 204);
            this.txtMainMeal.Name = "txtMainMeal";
            this.txtMainMeal.ReadOnly = true;
            this.txtMainMeal.Size = new System.Drawing.Size(102, 20);
            this.txtMainMeal.TabIndex = 4;
            // 
            // txtDessert
            // 
            this.txtDessert.Location = new System.Drawing.Point(124, 227);
            this.txtDessert.Name = "txtDessert";
            this.txtDessert.ReadOnly = true;
            this.txtDessert.Size = new System.Drawing.Size(102, 20);
            this.txtDessert.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbltotal);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.lblSubTotal);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Location = new System.Drawing.Point(14, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 103);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(21, 74);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(18, 48);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(18, 22);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(56, 13);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(110, 71);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(102, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(110, 45);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(102, 20);
            this.txtDiscount.TabIndex = 7;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(110, 19);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(102, 20);
            this.txtSubTotal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtDessert);
            this.Controls.Add(this.txtMainMeal);
            this.Controls.Add(this.txtStarter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UoM Cafe System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPublic;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radStaff;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDessert;
        private System.Windows.Forms.CheckBox chkMainMeal;
        private System.Windows.Forms.CheckBox chkStarter;
        private System.Windows.Forms.TextBox txtStarter;
        private System.Windows.Forms.TextBox txtMainMeal;
        private System.Windows.Forms.TextBox txtDessert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblDiscount;
    }
}

