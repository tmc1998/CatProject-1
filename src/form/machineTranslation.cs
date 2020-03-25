using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.machinetranslator;

namespace src.form
{
    public partial class machineTranslation : Form
    {
        public main mainForm;
        public List<machineTranslationBase> listMachine = new List<machineTranslationBase>(); 
        public machineTranslation(main MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;
        }
        private void machineTranslation_Load(object sender, EventArgs e)
        {
            initSize();
            initMachineTranslation(); 
        }
        public void initSize()
        {
            this.Left = mainForm.editorForm.Width + 2;
            this.Top = ParentForm.ClientRectangle.Height / 2 - 50;
        }
        private void initMachineTranslation()
        {
            //MyMemmory
            machineTranslationBase mymemory = new machineTranslationMyMemory();
            listMachine.Add(mymemory); 
        }
        public void setActiveMymemoryMachine(bool active)
        {
            if(listMachine.Count >= 0)
            {
                for(int i = 0; i < listMachine.Count; i++)
                {
                    if(listMachine[i] is machineTranslationMyMemory)
                    {
                        listMachine[i].isActive = active;
                        break; 
                    }
                }
            }
        }

        public void translate(string sourceText)
        {
            foreach(machineTranslationBase machine in listMachine)
            {
                if (machine.isActive)
                {
                    string text = machine.getTargetLang(sourceText);
                    rtbTranslated.Text = text;
                    Console.WriteLine(text);
                    Console.WriteLine(sourceText);
                    Console.WriteLine(machine.source + "::" + machine.target);
                }
            }
        }

        public void setSourceLangandTargetLangmachine(string source, string target)
        {
            for(int i = 0; i < listMachine.Count; i++)
            {
                listMachine[i].source = source;
                listMachine[i].target = target; 
            }
        }

        private void groupBoxMachineTranslation_Enter(object sender, EventArgs e)
        {

        }
    }
}
