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

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open file with excuse";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                Excuse _excuse = new Excuse(openFileDialog1.FileName);
                this.textBox_Excuse.Text = _excuse.Description;
                this.textBox_Result.Text = _excuse.Results;
                this.dateTimePicker_LastUsed.Value = _excuse.LastUsed;
            }

        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            Excuse _excuse = new Excuse(selectedFolder, true);
            this.textBox_Excuse.Text = _excuse.Description;
            this.textBox_Result.Text = _excuse.Results;
            this.dateTimePicker_LastUsed.Value = _excuse.LastUsed;
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

        private void UpdateForm(bool _changed)
        {
            if (!_changed)
            {
                this.textBox_Excuse.Text = currentExcuse.Description;
                this.textBox_Result.Text = currentExcuse.Results;
                this.dateTimePicker_LastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    label_FileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse MAnager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = _changed;
        }
    }
}
