﻿namespace src.form
{
    partial class machineTranslation
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
            this.groupBoxMachineTranslation = new System.Windows.Forms.GroupBox();
            this.rtbTranslated = new System.Windows.Forms.RichTextBox();
            this.groupBoxMachineTranslation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMachineTranslation
            // 
            this.groupBoxMachineTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMachineTranslation.Controls.Add(this.rtbTranslated);
            this.groupBoxMachineTranslation.Location = new System.Drawing.Point(3, 7);
            this.groupBoxMachineTranslation.Name = "groupBoxMachineTranslation";
            this.groupBoxMachineTranslation.Size = new System.Drawing.Size(460, 452);
            this.groupBoxMachineTranslation.TabIndex = 0;
            this.groupBoxMachineTranslation.TabStop = false;
            this.groupBoxMachineTranslation.Text = "Machine Translation";
            this.groupBoxMachineTranslation.Enter += new System.EventHandler(this.groupBoxMachineTranslation_Enter);
            // 
            // rtbTranslated
            // 
            this.rtbTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTranslated.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTranslated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTranslated.Location = new System.Drawing.Point(6, 19);
            this.rtbTranslated.Name = "rtbTranslated";
            this.rtbTranslated.ReadOnly = true;
            this.rtbTranslated.Size = new System.Drawing.Size(448, 427);
            this.rtbTranslated.TabIndex = 0;
            this.rtbTranslated.Text = "";
            // 
            // machineTranslation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 462);
            this.Controls.Add(this.groupBoxMachineTranslation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "machineTranslation";
            this.Text = "machineTranslation";
            this.Load += new System.EventHandler(this.machineTranslation_Load);
            this.groupBoxMachineTranslation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMachineTranslation;
        private System.Windows.Forms.RichTextBox rtbTranslated;
    }
}