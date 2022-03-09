namespace Lab17Q1
{
    partial class frmDatabase
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnPop2005 = new System.Windows.Forms.Button();
            this.btnMonetaryUnit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(442, 268);
            this.dataGridView.TabIndex = 0;
            // 
            // btnPop2005
            // 
            this.btnPop2005.Location = new System.Drawing.Point(12, 12);
            this.btnPop2005.Name = "btnPop2005";
            this.btnPop2005.Size = new System.Drawing.Size(124, 23);
            this.btnPop2005.TabIndex = 1;
            this.btnPop2005.Text = "Order by pop2005";
            this.btnPop2005.UseVisualStyleBackColor = true;
            this.btnPop2005.Click += new System.EventHandler(this.btnPopu2005_Click);
            // 
            // btnMonetaryUnit
            // 
            this.btnMonetaryUnit.Location = new System.Drawing.Point(330, 12);
            this.btnMonetaryUnit.Name = "btnMonetaryUnit";
            this.btnMonetaryUnit.Size = new System.Drawing.Size(124, 23);
            this.btnMonetaryUnit.TabIndex = 2;
            this.btnMonetaryUnit.Text = "Show Monetary Unit";
            this.btnMonetaryUnit.UseVisualStyleBackColor = true;
            this.btnMonetaryUnit.Click += new System.EventHandler(this.btnMonetaryUnit_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 321);
            this.Controls.Add(this.btnMonetaryUnit);
            this.Controls.Add(this.btnPop2005);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmDatabase";
            this.Text = "Database Management";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnPop2005;
        private System.Windows.Forms.Button btnMonetaryUnit;
    }
}

