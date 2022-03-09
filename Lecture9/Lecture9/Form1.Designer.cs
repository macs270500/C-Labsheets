namespace Lecture9
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(214, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Display Population";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstTable
            // 
            this.lstTable.FormattingEnabled = true;
            this.lstTable.Location = new System.Drawing.Point(12, 49);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(213, 121);
            this.lstTable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 186);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Population";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstTable;
    }
}

