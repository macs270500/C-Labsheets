namespace Lab7Q5
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
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radStrawberry = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.grpAdd_Ons = new System.Windows.Forms.GroupBox();
            this.chkChocoChips = new System.Windows.Forms.CheckBox();
            this.chkCookieCandy = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkFreshFruits = new System.Windows.Forms.CheckBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpFlavour.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpAdd_Ons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radStrawberry);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(25, 95);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(104, 123);
            this.grpFlavour.TabIndex = 0;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radStrawberry
            // 
            this.radStrawberry.AutoSize = true;
            this.radStrawberry.Location = new System.Drawing.Point(16, 75);
            this.radStrawberry.Name = "radStrawberry";
            this.radStrawberry.Size = new System.Drawing.Size(75, 17);
            this.radStrawberry.TabIndex = 2;
            this.radStrawberry.TabStop = true;
            this.radStrawberry.Text = "Strawberry";
            this.radStrawberry.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(16, 52);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(56, 17);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.TabStop = true;
            this.radVanilla.Text = "Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Location = new System.Drawing.Point(16, 29);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(73, 17);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(25, 224);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(104, 71);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(16, 42);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 1;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(16, 19);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(88, 31);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(177, 24);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.Text = "Zimis Ice-Cream";
            // 
            // grpAdd_Ons
            // 
            this.grpAdd_Ons.Controls.Add(this.chkFreshFruits);
            this.grpAdd_Ons.Controls.Add(this.chkNuts);
            this.grpAdd_Ons.Controls.Add(this.chkCookieCandy);
            this.grpAdd_Ons.Controls.Add(this.chkChocoChips);
            this.grpAdd_Ons.Location = new System.Drawing.Point(135, 95);
            this.grpAdd_Ons.Name = "grpAdd_Ons";
            this.grpAdd_Ons.Size = new System.Drawing.Size(176, 200);
            this.grpAdd_Ons.TabIndex = 3;
            this.grpAdd_Ons.TabStop = false;
            this.grpAdd_Ons.Text = "Add-Ons";
            // 
            // chkChocoChips
            // 
            this.chkChocoChips.AutoSize = true;
            this.chkChocoChips.Location = new System.Drawing.Point(17, 28);
            this.chkChocoChips.Name = "chkChocoChips";
            this.chkChocoChips.Size = new System.Drawing.Size(103, 17);
            this.chkChocoChips.TabIndex = 0;
            this.chkChocoChips.Text = "Chocolate Chips";
            this.chkChocoChips.UseVisualStyleBackColor = true;
            // 
            // chkCookieCandy
            // 
            this.chkCookieCandy.AutoSize = true;
            this.chkCookieCandy.Location = new System.Drawing.Point(17, 71);
            this.chkCookieCandy.Name = "chkCookieCandy";
            this.chkCookieCandy.Size = new System.Drawing.Size(126, 17);
            this.chkCookieCandy.TabIndex = 1;
            this.chkCookieCandy.Text = "Cookies and Candies";
            this.chkCookieCandy.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(17, 114);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(48, 17);
            this.chkNuts.TabIndex = 2;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkFreshFruits
            // 
            this.chkFreshFruits.AutoSize = true;
            this.chkFreshFruits.Location = new System.Drawing.Point(17, 157);
            this.chkFreshFruits.Name = "chkFreshFruits";
            this.chkFreshFruits.Size = new System.Drawing.Size(80, 17);
            this.chkFreshFruits.TabIndex = 3;
            this.chkFreshFruits.Text = "Fresh Fruits";
            this.chkFreshFruits.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(94, 320);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(135, 317);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(90, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 352);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.grpAdd_Ons);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpFlavour);
            this.Name = "Form1";
            this.Text = "Zimis Fresh Ice Cream";
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpAdd_Ons.ResumeLayout(false);
            this.grpAdd_Ons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radStrawberry;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.GroupBox grpAdd_Ons;
        private System.Windows.Forms.CheckBox chkFreshFruits;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCookieCandy;
        private System.Windows.Forms.CheckBox chkChocoChips;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

