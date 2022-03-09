namespace Assignment
{
    partial class InvCheckInventory
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
            this.btnExit = new System.Windows.Forms.Button();
            this.checkListView = new System.Windows.Forms.ListView();
            this.ProdId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkListView
            // 
            this.checkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.Qty});
            this.checkListView.HideSelection = false;
            this.checkListView.Location = new System.Drawing.Point(18, 13);
            this.checkListView.Name = "checkListView";
            this.checkListView.Size = new System.Drawing.Size(573, 258);
            this.checkListView.TabIndex = 1;
            this.checkListView.UseCompatibleStateImageBehavior = false;
            this.checkListView.View = System.Windows.Forms.View.Details;
            // 
            // ProdId
            // 
            this.ProdId.Text = "Product ID";
            this.ProdId.Width = 157;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Product Name";
            this.ProdName.Width = 202;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Text = "Product Price(Rs.)";
            this.ProdPrice.Width = 150;
            // 
            // Qty
            // 
            this.Qty.Text = "Quantity";
            // 
            // InvCheckInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 333);
            this.Controls.Add(this.checkListView);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvCheckInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvCheckInventory";
            this.Load += new System.EventHandler(this.InvCheckInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView checkListView;
        private System.Windows.Forms.ColumnHeader ProdId;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader ProdPrice;
        private System.Windows.Forms.ColumnHeader Qty;
    }
}