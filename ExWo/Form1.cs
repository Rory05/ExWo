using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exсel_Word
{
    public partial class ExWo : MetroSetForm
    {
        string filePath = null, folderPath = null, examplePath = null, deputyFilePath = null;
        public ExWo()
        {
            InitializeComponent();
        }


        private void exelbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*xlsx";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            label1.Text += "\n" + System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
            if(filePath!=null)
                exelbtn.Text = "Відкрито!";
        }

        private void folderbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
            }
            label2.Text += "\n" + folderPath;
            if(folderPath!=null)
                folderbtn.Text = "Відкрито!";
        }

        private void example_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Doc files (*.doc;*.docx)|*doc;*docx";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                examplePath = ofd.FileName;
            }
            label3.Text += "\n" + System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
            if(examplePath!=null)
                example.Text = "Відкрито!";
        }

        private void deputy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*xlsx";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                deputyFilePath = ofd.FileName;
            }
            label4.Text += "\n" + System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
            if (deputyFilePath != null)
                deputy.Text = "Відкрито!";
        }


        private void GO_Click(object sender, EventArgs e)
        {
            bool success = false;
            if(filePath==null || folderPath==null || examplePath==null || 
                ((ChBDF.Checked == true || ChBDeputy.Checked == true) && deputyFilePath == null))
            {
                 MessageBox.Show("Будь ласка, оберіть файли!", "Попередження!", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (!ChBLetter.Checked && !ChBDF.Checked && !ChBDeputy.Checked)
                {
                    MessageBox.Show("Будь ласка, оберіть тип створюваного файлу!", "Попередження!", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (ChBLetter.Checked)
                    { File file = new File(filePath, folderPath, examplePath); success = file.All(); }
                    else
                    {
                        if (ChBDF.Checked)
                        { DF df = new DF(filePath, folderPath, examplePath, deputyFilePath); success = df.All(); }
                        else
                        {
                            if (ChBDeputy.Checked)
                            { Deputy dep = new Deputy(filePath, folderPath, examplePath, deputyFilePath); success = dep.All(); }
                        }
                    }
                }
                
            }
            if (success)
                MessageBox.Show("Файли додані!", "Успішне створення", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }
    }
}
