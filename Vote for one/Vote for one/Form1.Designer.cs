namespace Vote_for_one
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
            this.radCandidate1 = new System.Windows.Forms.RadioButton();
            this.radCandidate2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.txtVote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCandidate1
            // 
            this.radCandidate1.AutoSize = true;
            this.radCandidate1.Location = new System.Drawing.Point(6, 32);
            this.radCandidate1.Name = "radCandidate1";
            this.radCandidate1.Size = new System.Drawing.Size(67, 17);
            this.radCandidate1.TabIndex = 0;
            this.radCandidate1.TabStop = true;
            this.radCandidate1.Text = "Kennedy";
            this.radCandidate1.UseVisualStyleBackColor = true;
            // 
            // radCandidate2
            // 
            this.radCandidate2.AutoSize = true;
            this.radCandidate2.Location = new System.Drawing.Point(6, 64);
            this.radCandidate2.Name = "radCandidate2";
            this.radCandidate2.Size = new System.Drawing.Size(52, 17);
            this.radCandidate2.TabIndex = 1;
            this.radCandidate2.TabStop = true;
            this.radCandidate2.Text = "Nixon";
            this.radCandidate2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCandidate2);
            this.groupBox1.Controls.Add(this.radCandidate1);
            this.groupBox1.Location = new System.Drawing.Point(107, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "President";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(66, 177);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(180, 44);
            this.btnVote.TabIndex = 3;
            this.btnVote.Text = "Cast Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // txtVote
            // 
            this.txtVote.Location = new System.Drawing.Point(42, 244);
            this.txtVote.Name = "txtVote";
            this.txtVote.ReadOnly = true;
            this.txtVote.Size = new System.Drawing.Size(223, 20);
            this.txtVote.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.txtVote);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vote for one";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCandidate1;
        private System.Windows.Forms.RadioButton radCandidate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.TextBox txtVote;
    }
}

