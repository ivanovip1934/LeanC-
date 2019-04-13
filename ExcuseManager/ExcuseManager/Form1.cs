using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool formChanged = false;
        private string selectedFolder = "";

        private void button_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if ( result == DialogResult.OK) {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                button_Save.Enabled = true;
                button_Open.Enabled = true;
                button_Random.Enabled = true;
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Excuse _excuse = new Excuse( this.textBox_Excuse.Text,
                                        this.textBox_Result.Text,
                                        this.dateTimePicker_LastUsed.Value
                                        );
            _excuse.Save(selectedFolder);
            this.Text = "Excuse Manager";
            this.formChanged = false;
            MessageBox.Show("Excuse written");
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.Title = "Open file with excuse";
                openFileDialog1.Filter = "Binary files (*.dat)|*.dat";
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = false;
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Excuse _excuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(_excuse);
                }
            }

        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            if (this.CheckChanged())
            {
                string[] _fileNames = Directory.GetFiles(selectedFolder, "*.dat");
                if (_fileNames.Length == 0 )
                {
                    MessageBox.Show("Please specify a folder with excuse files in it",
                        "No excuse files found");
                }
                else{
                    Excuse _excuse = new Excuse(selectedFolder, true);
                    UpdateForm(_excuse);
                }


            }
        }

        private void textBox_Excuse_TextChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void dateTimePicker_LastUsed_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void UpdateForm(bool _formchange) {
            this.Text = "Excuse Manager*";
            this.formChanged = true;
        }
        private void UpdateForm(Excuse _excuse)

        {
            this.textBox_Excuse.Text = _excuse.Description;
            this.textBox_Result.Text = _excuse.Results;
            this.dateTimePicker_LastUsed.Value = _excuse.LastUsed;
            if (!String.IsNullOrEmpty(_excuse.ExcusePath))
                label_FileDate.Text = File.GetLastWriteTime(_excuse.ExcusePath).ToString();
            this.Text = "Excuse Manager";
            this.formChanged = false;
        }

        private bool CheckChanged(){
            if (formChanged)
            {
                DialogResult _result = MessageBox.Show(
                    "The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_result == DialogResult.No)
                    return false;
            }
            return true;
        }
        
    }
}
