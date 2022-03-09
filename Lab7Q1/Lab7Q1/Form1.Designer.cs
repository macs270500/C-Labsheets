namespace Lab7Q1
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
            this.txtAdult = new System.Windows.Forms.TextBox();
            this.txtChrildren = new System.Windows.Forms.TextBox();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChrildren = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMovieTicketsDispenser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radEvening = new System.Windows.Forms.RadioButton();
            this.radAfternoon = new System.Windows.Forms.RadioButton();
            this.radMorning = new System.Windows.Forms.RadioButton();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdult
            // 
            this.txtAdult.Location = new System.Drawing.Point(94, 39);
            this.txtAdult.Name = "txtAdult";
            this.txtAdult.Size = new System.Drawing.Size(100, 20);
            this.txtAdult.TabIndex = 0;
            // 
            // txtChrildren
            // 
            this.txtChrildren.Location = new System.Drawing.Point(94, 79);
            this.txtChrildren.Name = "txtChrildren";
            this.txtChrildren.Size = new System.Drawing.Size(100, 20);
            this.txtChrildren.TabIndex = 1;
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(26, 42);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(36, 13);
            this.lblAdults.TabIndex = 2;
            this.lblAdults.Text = "Adults";
            // 
            // lblChrildren
            // 
            this.lblChrildren.AutoSize = true;
            this.lblChrildren.Location = new System.Drawing.Point(26, 82);
            this.lblChrildren.Name = "lblChrildren";
            this.lblChrildren.Size = new System.Drawing.Size(48, 13);
            this.lblChrildren.TabIndex = 3;
            this.lblChrildren.Text = "Chrildren";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChrildren);
            this.groupBox1.Controls.Add(this.lblAdults);
            this.groupBox1.Controls.Add(this.txtChrildren);
            this.groupBox1.Controls.Add(this.txtAdult);
            this.groupBox1.Location = new System.Drawing.Point(62, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Required";
            // 
            // txtMovieTicketsDispenser
            // 
            this.txtMovieTicketsDispenser.BackColor = System.Drawing.SystemColors.Control;
            this.txtMovieTicketsDispenser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieTicketsDispenser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTicketsDispenser.ForeColor = System.Drawing.Color.Blue;
            this.txtMovieTicketsDispenser.Location = new System.Drawing.Point(41, 26);
            this.txtMovieTicketsDispenser.Name = "txtMovieTicketsDispenser";
            this.txtMovieTicketsDispenser.Size = new System.Drawing.Size(394, 40);
            this.txtMovieTicketsDispenser.TabIndex = 5;
            this.txtMovieTicketsDispenser.Text = "Movie Ticket Dispenser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radEvening);
            this.groupBox2.Controls.Add(this.radAfternoon);
            this.groupBox2.Controls.Add(this.radMorning);
            this.groupBox2.Location = new System.Drawing.Point(300, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session";
            // 
            // radEvening
            // 
            this.radEvening.AutoSize = true;
            this.radEvening.Location = new System.Drawing.Point(7, 68);
            this.radEvening.Name = "radEvening";
            this.radEvening.Size = new System.Drawing.Size(64, 17);
            this.radEvening.TabIndex = 2;
            this.radEvening.TabStop = true;
            this.radEvening.Text = "Evening";
            this.radEvening.UseVisualStyleBackColor = true;
            // 
            // radAfternoon
            // 
            this.radAfternoon.AutoSize = true;
            this.radAfternoon.Location = new System.Drawing.Point(7, 44);
            this.radAfternoon.Name = "radAfternoon";
            this.radAfternoon.Size = new System.Drawing.Size(71, 17);
            this.radAfternoon.TabIndex = 1;
            this.radAfternoon.TabStop = true;
            this.radAfternoon.Text = "Afternoon";
            this.radAfternoon.UseVisualStyleBackColor = true;
            // 
            // radMorning
            // 
            this.radMorning.AutoSize = true;
            this.radMorning.Location = new System.Drawing.Point(7, 20);
            this.radMorning.Name = "radMorning";
            this.radMorning.Size = new System.Drawing.Size(63, 17);
            this.radMorning.TabIndex = 0;
            this.radMorning.TabStop = true;
            this.radMorning.Text = "Morning";
            this.radMorning.UseVisualStyleBackColor = true;
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(156, 223);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 7;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(82, 226);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(54, 13);
            this.lblDue.TabIndex = 8;
            this.lblDue.Text = "Total Due";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(41, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 27);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 27);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 27);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMovieTicketsDispenser);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Movie Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdult;
        private System.Windows.Forms.TextBox txtChrildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChrildren;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMovieTicketsDispenser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radEvening;
        private System.Windows.Forms.RadioButton radAfternoon;
        private System.Windows.Forms.RadioButton radMorning;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

