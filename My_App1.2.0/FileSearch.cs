using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Configuration;
using System.Data;
using System.Drawing;       
using System.IO;  
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms;   

namespace My_App1._2._0
{
    public partial class FileSearch : Form
    {
        public FileSearch()
        {
            InitializeComponent();
        }
        private void Browse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            Search_txtbox.Text = f.SelectedPath;
        }
        string[] totalfiles = new string[] { };
        private void Search_Button_Click(object sender, EventArgs e)
        {
            int count = 0;
            string filename = FileName_textBox.Text;
            string type = "." + File_Type_comboBox.Text;
            TotalFiles_textBox.Clear();
            string[] rootpath = new string[] { Search_txtbox.Text + "\\" };
            foreach (string path in rootpath)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
            }
            FileCount.Text = "Total File Count is " + count;

            void ProcessDirectory(string rootfolder)
            {
                //Getting Files from subdirectories
                string[] Folders = Directory.GetFiles(rootfolder);
                foreach (string fileName in Folders)
                    ProcessFile(fileName);

                // Recurse into subdirectories of this directory.
                string[] SubFolders = Directory.GetDirectories(rootfolder);
                foreach (string subdirectory in SubFolders)
                    ProcessDirectory(subdirectory);

            }
            //Processing the file found in directory
            void ProcessFile(string rootfolder)
            {
                string file = null;
                file = Path.GetFileName(rootfolder);
                file = file.ToLower();
                if (file.Contains(FileName_textBox.Text))
                {
                    if (Path.GetExtension(rootfolder) == type)
                    {
                        count += 1;
                        totalfiles.Append(file);
                        TotalFiles_textBox.Text += count + ". " + file + Environment.NewLine;
                        
                    }
                }
            }
         
        }
        private void export_button_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["LogPath"];
            try
            {
                if (File.Exists(path))
                {
                    //writes to file
                 File.WriteAllText(path, TotalFiles_textBox.Text);
                }
                else
                {
                    // Create the file.
                    using (FileStream fs = File.Create(path))
                    {
                        File.WriteAllText(path, TotalFiles_textBox.Text);
                    }
                }
            }
            catch  { }
        }
        private void TotalFiles_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Search_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileName_label_Click(object sender, EventArgs e)
        {

        }

        private void FileName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void File_Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void File_Type_label_Click(object sender, EventArgs e)
        {

        }

        private void FileCount_Click(object sender, EventArgs e)
        {

        }

        private void FilesImported_Click(object sender, EventArgs e)
        {

        }
    }
}
