namespace src.form
{
    partial class editor
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
            this.lblEditor = new System.Windows.Forms.Label();
            this.editorGrid = new System.Windows.Forms.DataGridView();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbTutorial = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblEditor);
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(920, 36);
            this.panelTop.TabIndex = 0;
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditor.Location = new System.Drawing.Point(3, 10);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(34, 13);
            this.lblEditor.TabIndex = 0;
            this.lblEditor.Text = "Editor";
            // 
            // editorGrid
            // 
            this.editorGrid.AllowUserToAddRows = false;
            this.editorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.editorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceColumn,
            this.targetColumn});
            this.editorGrid.Location = new System.Drawing.Point(12, 54);
            this.editorGrid.MultiSelect = false;
            this.editorGrid.Name = "editorGrid";
            this.editorGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.editorGrid.RowHeadersVisible = false;
            this.editorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.editorGrid.Size = new System.Drawing.Size(920, 399);
            this.editorGrid.TabIndex = 1;
            this.editorGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellClick);
            this.editorGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellContentClick);
            this.editorGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellEndEdit);
            // 
            // sourceColumn
            // 
            this.sourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sourceColumn.HeaderText = "Source";
            this.sourceColumn.Name = "sourceColumn";
            this.sourceColumn.ReadOnly = true;
            this.sourceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // targetColumn
            // 
            this.targetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetColumn.HeaderText = "Target";
            this.targetColumn.Name = "targetColumn";
            this.targetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rtbTutorial
            // 
            this.rtbTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTutorial.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTutorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTutorial.Location = new System.Drawing.Point(12, 54);
            this.rtbTutorial.Name = "rtbTutorial";
            this.rtbTutorial.ReadOnly = true;
            this.rtbTutorial.Size = new System.Drawing.Size(920, 399);
            this.rtbTutorial.TabIndex = 2;
            this.rtbTutorial.Text = "";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 483);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(949, 1);
            this.panelBottom.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 483);
            this.panelRight.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(948, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1, 483);
            this.panelLeft.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 1);
            this.panel1.TabIndex = 6;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.rtbTutorial);
            this.Controls.Add(this.editorGrid);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.DataGridView editorGrid;
        private System.Windows.Forms.RichTextBox rtbTutorial;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
    }
}