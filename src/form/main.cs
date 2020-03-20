﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.form;
using src.project; 
using System.IO;
using System.Xml;
using src.messagebox;
using src.Files;
using src.segment;

namespace src.form
{
    public partial class main : Form
    {
        public Project project; 
        public fuzzymatches fuzzymatchesForm; 
        public editor editorForm;
        public createNewProject creatNewProjectForm;
        public projectfiles projectFilesForm;
        public string filter = "cat|*.cat";
        public string catname = "CAT"; 
        public System.Windows.Forms.Form ParentForm { get; }

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //openChildForm();
            setBackColor();
            initControl(); 
            openChildForm();
            openIntroduction();
            //initProject(); 
            //openProjectFilesForm();
        }

        public void setProject(Project Project)
        {
            this.project = new Project(); 
            this.project = Project; 
        }
        public void initProject()
        {
            
        }

        private void initControl()
        {
            if(project == null)
            {
                reloadToolStripMenuItem.Enabled = false;  
            }
            if(project == null)
            {
                SaveToolStripMenuItem.Enabled = false; 
            }
            if(project == null)
            {
                createTranslatedDocumentToolStripMenuItem.Enabled = false; 
            }
        }

        private void reloadControl()
        {
            if(project != null)
            {
                reloadToolStripMenuItem.Enabled = true; 
            }
            if(project != null)
            {
                SaveToolStripMenuItem.Enabled = true; 
            }
            if(project != null)
            {
                createTranslatedDocumentToolStripMenuItem.Enabled = true; 
            }
        }

        private void reloadNameCAT()
        {
            if(project != null)
            {
                this.Text = catname + "::" + project.getNameProject(); 
            }
        }

        public void createNewProject()
        {
            //Tạo folder làm việc
            if (this.project != null)
            {
                project.createProject(); 
                string path = Path.Combine(this.project.getPathProject(),this.project.getNameFileProject());
                loadProject(path); 
            }
        }

        public void loadProject(string path)
        {
            this.project = new Project();
            if (path != null)
            {
                if (this.project.readProject(path))
                {
                    if (project != null)
                    {
                        if (project.isEmptySourceFolder())
                        {
                            editorForm.openTutorial();
                        }
                        else
                        {

                        }
                        openProjectFilesForm();
                        reloadControl();
                        reloadNameCAT(); 
                    }
                }
                else
                {
                    TextOfMessageBox a = new TextOfMessageBox();
                    MessageBox.Show(a.FILE_NOT_FOUND, "Cảnh báo", MessageBoxButtons.YesNo);
                }
            }
        }

        //public void createXMLFileProject(string fileName)
        //{
        //    string filename = project.getPathProject() + "\\" + fileName; 

        //}

        public void setAndReadCurrentFileProject(file file)
        {
            if(project != null)
            {
                project.setCurrentFile(file); 
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCreateProjectForm(); 
        }

        public void openChildForm()
        {
            fuzzymatchesForm = new fuzzymatches();
            fuzzymatchesForm.MdiParent = this;
            fuzzymatchesForm.Show();

        }

        public void openIntroduction()
        {
            if (editorForm == null)
            {
                editorForm = new editor(this);
                editorForm.MdiParent = this;
                editorForm.Show();
            }
            //editorForm.openEditor();
        }
        public void openEditorForm()
        {
            if(editorForm != null)
            {
                editorForm.openEditor(); 
            }
        }

        public void openCreateProjectForm()
        {
            if (creatNewProjectForm == null)
            {
                creatNewProjectForm = new createNewProject(this);
                creatNewProjectForm.Show();
            }
        }

        public void closeCreateProjectForm()
        {
            if(creatNewProjectForm != null)
            {
                creatNewProjectForm = null; 
            }
        }

        public void openProjectFilesForm()
        {
            if (projectFilesForm == null)
            {
                projectFilesForm = new projectfiles(this);
                projectFilesForm.Show();
            }
        }

        public void closeProjectFilesForm()
        {
            if(projectFilesForm != null)
            {
                projectFilesForm = null; 
            }
        }

        public void readContentFile()
        {
            if(project.getCurrentFile() != null)
            {
                project.readContentCurrentFile(); 
            }
        }

       public Form GetForm()
        {
            return fuzzymatchesForm;
        }

        public void setBackColor()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = SystemColors.Control;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectFilesForm == null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = filter;
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string path = ofd.FileName;
                        loadProject(path);
                    }
                }
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (project != null)
            {
                string path = Path.Combine(this.project.getPathProject(), this.project.getNameFileProject());
                loadProject(path);
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(project != null)
            {
                if(project.getCurrentFile() == null)
                {
                    TextOfMessageBox a = new TextOfMessageBox();
                    MessageBox.Show(a.NO_FILE_TO_SAVE, "Cảnh báo", MessageBoxButtons.YesNo);
                }
                else
                {
                    project.saveProject(); 
                }
            }
        }

        private void createTranslatedDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(project != null)
            {
                project.createTranslatedDocument();
                TextOfMessageBox a = new TextOfMessageBox();
                MessageBox.Show(a.CREATE_TRASLATED_DOCUMENT_SUCCESSFULLY,"Thông báo", MessageBoxButtons.YesNo);
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(project != null)
            {
                project.saveProject(); 
            }
        }
    }
}
