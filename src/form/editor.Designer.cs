﻿namespace src.form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblEditor = new System.Windows.Forms.Label();
            this.editorGrid = new System.Windows.Forms.DataGridView();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbTutorial = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblEditor);
            this.panelTop.Location = new System.Drawing.Point(12, 154);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1069, 25);
            this.panelTop.TabIndex = 0;
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditor.Location = new System.Drawing.Point(3, 5);
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
            this.editorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.editorGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.editorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceColumn,
            this.targetColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editorGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.editorGrid.Location = new System.Drawing.Point(6, 19);
            this.editorGrid.MultiSelect = false;
            this.editorGrid.Name = "editorGrid";
            this.editorGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.editorGrid.RowHeadersVisible = false;
            this.editorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.editorGrid.Size = new System.Drawing.Size(1112, 473);
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
            this.targetColumn.MinimumWidth = 100;
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
            this.rtbTutorial.Location = new System.Drawing.Point(6, 19);
            this.rtbTutorial.Name = "rtbTutorial";
            this.rtbTutorial.ReadOnly = true;
            this.rtbTutorial.Size = new System.Drawing.Size(1112, 473);
            this.rtbTutorial.TabIndex = 2;
            this.rtbTutorial.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbTutorial);
            this.groupBox1.Controls.Add(this.editorGrid);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 500);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hướng dẫn";
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1130, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.DataGridView editorGrid;
        private System.Windows.Forms.RichTextBox rtbTutorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}