namespace Assignment
{
    partial class InvDetailedView
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
            this.detailedListView = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detailedListView
            // 
            this.detailedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.Quantity});
            this.detailedListView.FullRowSelect = true;
            this.detailedListView.HideSelection = false;
            this.detailedListView.Location = new System.Drawing.Point(13, 20);
            this.detailedListView.Name = "detailedListView";
            this.detailedListView.Size = new System.Drawing.Size(470, 212);
            this.detailedListView.TabIndex = 0;
            this.detailedListView.UseCompatibleStateImageBehavior = false;
            this.detailedListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Product Id";
            this.ProductId.Width = 82;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 147;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Product Price(Rs.)";
            this.ProductPrice.Width = 156;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 81;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(211, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InvDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 296);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.detailedListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvDetailedView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvDetailedView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView detailedListView;
    }
}