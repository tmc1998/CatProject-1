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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblfuzzymatches);
            this.panelTop.Location = new System.Drawing.Point(29, 175);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(219, 38);
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
            this.rtbFuzzyMatches.Location = new System.Drawing.Point(8, 19);
            this.rtbFuzzyMatches.Name = "rtbFuzzyMatches";
            this.rtbFuzzyMatches.ReadOnly = true;
            this.rtbFuzzyMatches.Size = new System.Drawing.Size(780, 429);
            this.rtbFuzzyMatches.TabIndex = 1;
            this.rtbFuzzyMatches.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbFuzzyMatches);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 454);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuzzy matched";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fuzzymatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fuzzymatches";
            this.Text = "fuzzymatches";
            this.Load += new System.EventHandler(this.fuzzymatches_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblfuzzymatches;
        private System.Windows.Forms.RichTextBox rtbFuzzyMatches;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}