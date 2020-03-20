namespace src.form
{
    partial class projectfiles
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
            this.components = new System.ComponentModel.Container();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lbltimecreation = new System.Windows.Forms.Label();
            this.lblLocationFile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageListIcon;
            this.listViewFiles.Location = new System.Drawing.Point(8, 12);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(481, 548);
            this.listViewFiles.SmallImageList = this.imageListIcon;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcon.TransparentColor = System.Drawing.Color.White;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(3, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tên dự án : ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(3, 57);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(81, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Địa chỉ tập tin : ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(533, 71);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Mở tập tin";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(519, 206);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(89, 23);
            this.btnHorizontal.TabIndex = 5;
            this.btnHorizontal.Text = "Sắp xếp ngang";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(519, 255);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(89, 23);
            this.btnVertical.TabIndex = 6;
            this.btnVertical.Text = "Sắp xếp dọc";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Location = new System.Drawing.Point(85, 13);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(35, 13);
            this.lblNameProject.TabIndex = 7;
            this.lblNameProject.Text = "label1";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Location = new System.Drawing.Point(3, 35);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(75, 13);
            this.lblCreationTime.TabIndex = 8;
            this.lblCreationTime.Text = "Thời gian tạo :";
            // 
            // lbltimecreation
            // 
            this.lbltimecreation.AutoSize = true;
            this.lbltimecreation.Location = new System.Drawing.Point(85, 35);
            this.lbltimecreation.Name = "lbltimecreation";
            this.lbltimecreation.Size = new System.Drawing.Size(35, 13);
            this.lbltimecreation.TabIndex = 9;
            this.lbltimecreation.Text = "label1";
            // 
            // lblLocationFile
            // 
            this.lblLocationFile.AutoSize = true;
            this.lblLocationFile.Location = new System.Drawing.Point(85, 57);
            this.lblLocationFile.Name = "lblLocationFile";
            this.lblLocationFile.Size = new System.Drawing.Size(35, 13);
            this.lblLocationFile.TabIndex = 10;
            this.lblLocationFile.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lblLocationFile);
            this.panel1.Controls.Add(this.lblNameProject);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lbltimecreation);
            this.panel1.Controls.Add(this.lblCreationTime);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Location = new System.Drawing.Point(6, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listViewFiles);
            this.panel2.Controls.Add(this.btnHorizontal);
            this.panel2.Controls.Add(this.btnVertical);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 583);
            this.panel2.TabIndex = 12;
            // 
            // projectfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "projectfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.projectfiles_FormClosing);
            this.Load += new System.EventHandler(this.projectfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lbltimecreation;
        private System.Windows.Forms.Label lblLocationFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}