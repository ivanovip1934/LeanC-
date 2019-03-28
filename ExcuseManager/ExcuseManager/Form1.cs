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

        }

        private void button_Open_Click(object sender, EventArgs e)
        {

        }

        private void button_Random_Click(object sender, EventArgs e)
        {

        }
    }
}
