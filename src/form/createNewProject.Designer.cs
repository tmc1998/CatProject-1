namespace src.form
{
    partial class createNewProject
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelProject = new System.Windows.Forms.Panel();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.cboTranslatedFilesLanguage = new System.Windows.Forms.ComboBox();
            this.lblTranslatedFilesLanguage = new System.Windows.Forms.Label();
            this.cboSourceFilesLanguage = new System.Windows.Forms.ComboBox();
            this.lblSourceFilesLanguage = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelProject.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(0, 9);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(62, 13);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Tên dự án :";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(3, 25);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(439, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(0, 48);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Đường dẫn :";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(3, 64);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(363, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(367, 62);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelProject
            // 
            this.panelProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProject.Controls.Add(this.txtLocation);
            this.panelProject.Controls.Add(this.btnBrowse);
            this.panelProject.Controls.Add(this.lblLocation);
            this.panelProject.Controls.Add(this.txtProjectName);
            this.panelProject.Controls.Add(this.lblProjectName);
            this.panelProject.Location = new System.Drawing.Point(4, 23);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(447, 97);
            this.panelProject.TabIndex = 5;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(5, 7);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(36, 13);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Dự án";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(5, 128);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(57, 13);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Ngôn ngữ ";
            // 
            // panelLanguage
            // 
            this.panelLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLanguage.Controls.Add(this.cboTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.cboSourceFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblSourceFilesLanguage);
            this.panelLanguage.Location = new System.Drawing.Point(4, 144);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(447, 113);
            this.panelLanguage.TabIndex = 8;
            // 
            // cboTranslatedFilesLanguage
            // 
            this.cboTranslatedFilesLanguage.FormattingEnabled = true;
            this.cboTranslatedFilesLanguage.Location = new System.Drawing.Point(3, 66);
            this.cboTranslatedFilesLanguage.Name = "cboTranslatedFilesLanguage";
            this.cboTranslatedFilesLanguage.Size = new System.Drawing.Size(439, 21);
            this.cboTranslatedFilesLanguage.TabIndex = 3;
            // 
            // lblTranslatedFilesLanguage
            // 
            this.lblTranslatedFilesLanguage.AutoSize = true;
            this.lblTranslatedFilesLanguage.Location = new System.Drawing.Point(0, 50);
            this.lblTranslatedFilesLanguage.Name = "lblTranslatedFilesLanguage";
            this.lblTranslatedFilesLanguage.Size = new System.Drawing.Size(115, 13);
            this.lblTranslatedFilesLanguage.TabIndex = 2;
            this.lblTranslatedFilesLanguage.Text = "Ngôn ngữ tập tin dịch :";
            // 
            // cboSourceFilesLanguage
            // 
            this.cboSourceFilesLanguage.FormattingEnabled = true;
            this.cboSourceFilesLanguage.Location = new System.Drawing.Point(3, 26);
            this.cboSourceFilesLanguage.Name = "cboSourceFilesLanguage";
            this.cboSourceFilesLanguage.Size = new System.Drawing.Size(439, 21);
            this.cboSourceFilesLanguage.TabIndex = 1;
            // 
            // lblSourceFilesLanguage
            // 
            this.lblSourceFilesLanguage.AutoSize = true;
            this.lblSourceFilesLanguage.Location = new System.Drawing.Point(0, 10);
            this.lblSourceFilesLanguage.Name = "lblSourceFilesLanguage";
            this.lblSourceFilesLanguage.Size = new System.Drawing.Size(125, 13);
            this.lblSourceFilesLanguage.TabIndex = 0;
            this.lblSourceFilesLanguage.Text = "Ngôn ngữ tập tin nguồn :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(285, 271);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Tạo mới ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // createNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.panelProject);
            this.Name = "createNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createNewProject_FormClosing);
            this.Load += new System.EventHandler(this.createNewProject_Load);
            this.panelProject.ResumeLayout(false);
            this.panelProject.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.ComboBox cboTranslatedFilesLanguage;
        private System.Windows.Forms.Label lblTranslatedFilesLanguage;
        private System.Windows.Forms.ComboBox cboSourceFilesLanguage;
        private System.Windows.Forms.Label lblSourceFilesLanguage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}