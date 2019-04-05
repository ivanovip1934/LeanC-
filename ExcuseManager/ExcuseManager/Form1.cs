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

        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        private void button_Folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if ( result == DialogResult.OK) {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                button_Save.Enabled = true;
                button_Open.Enabled = true;
                button_Random.Enabled = true;
            }

        }

        private void button_Save_Click(object sender, EventArgs e){
            if (String.IsNullOrEmpty(textBox_Excuse.Text) || String.IsNullOrEmpty(textBox_Result.Text)) {
                MessageBox.Show("Please specify an excuse and a result",
                    "Unamble to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.FileName = textBox_Excuse.Text + ".txt";
            DialogResult _result = saveFileDialog1.ShowDialog();
            if (_result == DialogResult.OK) {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (this.CheckChanged()){
                openFileDialog1.Title = "Open file with excuse";
                openFileDialog1.Filter = "Text files (*.txt)|*.txt";
                openFileDialog1.FileName = this.textBox_Excuse.Text + ".txt";
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = false;
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK){
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            if (this.CheckChanged()){
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged() {
            if (formChanged) {
                DialogResult _result = MessageBox.Show(
                    "The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_result == DialogResult.No)
                    return false;
            }
            return true;
        }


        private void textBox_Excuse_TextChanged(object sender, EventArgs e){
            currentExcuse.Description = textBox_Excuse.Text;
            UpdateForm(true);
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBox_Result.Text;
            UpdateForm(true);
        }

        private void dateTimePicker_LastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePicker_LastUsed.Value;
            UpdateForm(true);
        }

        private void UpdateForm(bool _changed) {
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
