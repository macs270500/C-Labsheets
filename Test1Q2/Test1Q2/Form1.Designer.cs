namespace Test1Q2
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
            this.lstStarter = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFr = new System.Windows.Forms.RadioButton();
            this.RadFN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkE = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Catering";
            // 
            // lstStarter
            // 
            this.lstStarter.FormattingEnabled = true;
            this.lstStarter.Items.AddRange(new object[] {
            "Fried Chicken",
            "Crispy Prawns",
            "Veg Spring Rolls"});
            this.lstStarter.Location = new System.Drawing.Point(6, 19);
            this.lstStarter.Name = "lstStarter";
            this.lstStarter.Size = new System.Drawing.Size(116, 69);
            this.lstStarter.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstStarter);
            this.groupBox1.Location = new System.Drawing.Point(26, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starter (Optional)";
            // 
            // radFr
            // 
            this.radFr.AutoSize = true;
            this.radFr.Location = new System.Drawing.Point(6, 18);
            this.radFr.Name = "radFr";
            this.radFr.Size = new System.Drawing.Size(76, 17);
            this.radFr.TabIndex = 0;
            this.radFr.TabStop = true;
            this.radFr.Text = "Fried Rice ";
            this.radFr.UseVisualStyleBackColor = true;
            // 
            // RadFN
            // 
            this.RadFN.AutoSize = true;
            this.RadFN.Location = new System.Drawing.Point(88, 18);
            this.RadFN.Name = "RadFN";
            this.RadFN.Size = new System.Drawing.Size(90, 17);
            this.RadFN.TabIndex = 1;
            this.RadFN.TabStop = true;
            this.RadFN.Text = "Fried Noodles";
            this.RadFN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadFN);
            this.groupBox2.Controls.Add(this.radFr);
            this.groupBox2.Location = new System.Drawing.Point(160, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Meal";
            // 
            // chkE
            // 
            this.chkE.AutoSize = true;
            this.chkE.Location = new System.Drawing.Point(6, 30);
            this.chkE.Name = "chkE";
            this.chkE.Size = new System.Drawing.Size(45, 17);
            this.chkE.TabIndex = 0;
            this.chkE.Text = "Egg";
            this.chkE.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(88, 30);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(65, 17);
            this.chkC.TabIndex = 1;
            this.chkC.Text = "Chicken";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkC);
            this.groupBox3.Controls.Add(this.chkE);
            this.groupBox3.Location = new System.Drawing.Point(160, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add-Ons (Optional)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(92, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ABC Catering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstStarter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFr;
        private System.Windows.Forms.RadioButton RadFN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkE;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
    }
}

