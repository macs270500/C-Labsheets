namespace Lab16Q3
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
            this.btnShowData = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(181, 12);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(97, 23);
            this.btnShowData.TabIndex = 0;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // lstData
            // 
            this.lstData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 14;
            this.lstData.Location = new System.Drawing.Point(12, 41);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(434, 214);
            this.lstData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 281);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnShowData);
            this.Name = "Form1";
            this.Text = "Display a Table Programatically";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ListBox lstData;
    }
}

