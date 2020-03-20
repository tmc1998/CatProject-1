namespace src.form
{
    partial class fuzzymatches
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblfuzzymatches = new System.Windows.Forms.Label();
            this.rtbFuzzyMatches = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblfuzzymatches);
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(928, 38);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // lblfuzzymatches
            // 
            this.lblfuzzymatches.AutoSize = true;
            this.lblfuzzymatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuzzymatches.Location = new System.Drawing.Point(3, 12);
            this.lblfuzzymatches.Name = "lblfuzzymatches";
            this.lblfuzzymatches.Size = new System.Drawing.Size(96, 16);
            this.lblfuzzymatches.TabIndex = 0;
            this.lblfuzzymatches.Text = "Fuzzy matches";
            this.lblfuzzymatches.Click += new System.EventHandler(this.lblfuzzymatches_Click);
            // 
            // rtbFuzzyMatches
            // 
            this.rtbFuzzyMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFuzzyMatches.BackColor = System.Drawing.SystemColors.Window;
            this.rtbFuzzyMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFuzzyMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFuzzyMatches.Location = new System.Drawing.Point(12, 56);
            this.rtbFuzzyMatches.Name = "rtbFuzzyMatches";
            this.rtbFuzzyMatches.ReadOnly = true;
            this.rtbFuzzyMatches.Size = new System.Drawing.Size(928, 382);
            this.rtbFuzzyMatches.TabIndex = 1;
            this.rtbFuzzyMatches.Text = "";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 449);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(952, 1);
            this.panelBottom.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1, 449);
            this.panelLeft.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(951, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 449);
            this.panelRight.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 1);
            this.panel1.TabIndex = 5;
            // 
            // fuzzymatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.rtbFuzzyMatches);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fuzzymatches";
            this.Text = "fuzzymatches";
            this.Load += new System.EventHandler(this.fuzzymatches_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblfuzzymatches;
        private System.Windows.Forms.RichTextBox rtbFuzzyMatches;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel1;
    }
}