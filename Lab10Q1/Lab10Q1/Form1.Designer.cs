namespace Lab10Q1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radVisiting = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCleaning = new System.Windows.Forms.CheckBox();
            this.chkCavity = new System.Windows.Forms.CheckBox();
            this.chkX_Ray = new System.Windows.Forms.CheckBox();
            this.txtCleaning = new System.Windows.Forms.TextBox();
            this.txtCavity = new System.Windows.Forms.TextBox();
            this.txtX_Ray = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVisiting);
            this.groupBox1.Controls.Add(this.radRegular);
            this.groupBox1.Location = new System.Drawing.Point(36, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(13, 24);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(62, 17);
            this.radRegular.TabIndex = 0;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radVisiting
            // 
            this.radVisiting.AutoSize = true;
            this.radVisiting.Location = new System.Drawing.Point(13, 47);
            this.radVisiting.Name = "radVisiting";
            this.radVisiting.Size = new System.Drawing.Size(58, 17);
            this.radVisiting.TabIndex = 1;
            this.radVisiting.TabStop = true;
            this.radVisiting.Text = "Visiting";
            this.radVisiting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtX_Ray);
            this.groupBox2.Controls.Add(this.txtCavity);
            this.groupBox2.Controls.Add(this.txtCleaning);
            this.groupBox2.Controls.Add(this.chkX_Ray);
            this.groupBox2.Controls.Add(this.chkCavity);
            this.groupBox2.Controls.Add(this.chkCleaning);
            this.groupBox2.Location = new System.Drawing.Point(36, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treatment";
            // 
            // chkCleaning
            // 
            this.chkCleaning.AutoSize = true;
            this.chkCleaning.Location = new System.Drawing.Point(13, 20);
            this.chkCleaning.Name = "chkCleaning";
            this.chkCleaning.Size = new System.Drawing.Size(67, 17);
            this.chkCleaning.TabIndex = 0;
            this.chkCleaning.Text = "Cleaning";
            this.chkCleaning.UseVisualStyleBackColor = true;
            // 
            // chkCavity
            // 
            this.chkCavity.AutoSize = true;
            this.chkCavity.Location = new System.Drawing.Point(13, 43);
            this.chkCavity.Name = "chkCavity";
            this.chkCavity.Size = new System.Drawing.Size(84, 17);
            this.chkCavity.TabIndex = 1;
            this.chkCavity.Text = "Cavity Filling";
            this.chkCavity.UseVisualStyleBackColor = true;
            // 
            // chkX_Ray
            // 
            this.chkX_Ray.AutoSize = true;
            this.chkX_Ray.Location = new System.Drawing.Point(13, 66);
            this.chkX_Ray.Name = "chkX_Ray";
            this.chkX_Ray.Size = new System.Drawing.Size(55, 17);
            this.chkX_Ray.TabIndex = 2;
            this.chkX_Ray.Text = "X-Ray";
            this.chkX_Ray.UseVisualStyleBackColor = true;
            // 
            // txtCleaning
            // 
            this.txtCleaning.Location = new System.Drawing.Point(106, 18);
            this.txtCleaning.Name = "txtCleaning";
            this.txtCleaning.Size = new System.Drawing.Size(100, 20);
            this.txtCleaning.TabIndex = 3;
            // 
            // txtCavity
            // 
            this.txtCavity.Location = new System.Drawing.Point(106, 41);
            this.txtCavity.Name = "txtCavity";
            this.txtCavity.Size = new System.Drawing.Size(100, 20);
            this.txtCavity.TabIndex = 4;
            // 
            // txtX_Ray
            // 
            this.txtX_Ray.Location = new System.Drawing.Point(106, 64);
            this.txtX_Ray.Name = "txtX_Ray";
            this.txtX_Ray.Size = new System.Drawing.Size(100, 20);
            this.txtX_Ray.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(142, 260);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(99, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dental Services";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radVisiting;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX_Ray;
        private System.Windows.Forms.TextBox txtCavity;
        private System.Windows.Forms.TextBox txtCleaning;
        private System.Windows.Forms.CheckBox chkX_Ray;
        private System.Windows.Forms.CheckBox chkCavity;
        private System.Windows.Forms.CheckBox chkCleaning;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}

