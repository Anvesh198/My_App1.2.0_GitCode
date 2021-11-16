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
        int c = 1;
        List<string> totalfiles = new List<string>();
        public FileSearch()
        {
            InitializeComponent();
           
        }
        string type1;
        public async Task GetFile()
        {
            totalfiles.Clear();
            int count = 0;
            string filename = FileName_textBox.Text;
            string type = "." + File_Type_comboBox.Text;
            type1=File_Type_comboBox.Text;
            TotalFiles_textBox.Clear();
            string[] rootpath = new string[] { Search_txtbox.Text + "\\" };
            foreach (string path in rootpath)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                   await ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    await ProcessDirectory (path);
                }
            }
            FileCount.Text = "Total File Count is " + count;

           async Task ProcessDirectory(string rootfolder)
            {
                //Getting Files from subdirectories
                string[] Folders = Directory.GetFiles(rootfolder);
                foreach (string fileName in Folders)
                   await ProcessFile(fileName);

                // Recurse into subdirectories of this directory.
                string[] SubFolders = Directory.GetDirectories(rootfolder);
                foreach (string subdirectory in SubFolders)
                    await ProcessDirectory(subdirectory);

            }
            //Processing the file found in directory
             async Task ProcessFile(string rootfolder)
            {
                string file = null;
                file = Path.GetFileName(rootfolder);
                file = file.ToLower();
                if (file.Contains(FileName_textBox.Text))
                {
                    if (Path.GetExtension(rootfolder) == type)
                    {
                        count += 1;
                        totalfiles.Add(count + " " + file);
                        TotalFiles_textBox.Text += count + ". " + file + Environment.NewLine;
                    }
                }
            }
            
        }
        string[] s=new string[] { };
        private void Browse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            Search_txtbox.Text = f.SelectedPath;
            string str = f.SelectedPath;
            s = str.Split('\\');

        }
        string foldername;
        private async void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                await GetFile();
            }
            catch(Exception error)
            {
                MessageBox.Show("Please Enter Data", "Error", MessageBoxButtons.OK);
            }
            foreach (string item in s)
            {
                foldername= item;
            }
            Form1.quantity +="Folder Name: "+ foldername.ToUpper()+ 
            " & "+type1.ToUpper()+" Files Found: "+totalfiles.Count+"$";
        }
        private void export_button_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["LogPath"];
            try
            {
                if (File.Exists(path))
                {
                    //writes to file
                    using (StreamWriter s = new StreamWriter(path))
                    {
                        foreach (string item in totalfiles)
                        {
                            s.WriteLine(item + "   Date:" + DateTime.Now);
                        }
                    }
                }
                else
                {
                    // Create the file.
                    FileStream fs = File.Create(path);
                    using (StreamWriter s = new StreamWriter(path))
                    {
                        foreach (string item in totalfiles)
                        {
                            s.WriteLine(item + "   Date:" + DateTime.Now);
                        }
                    }
                }
               
            }
            catch { }
            FilesImported.Text = "Files Exported to Log File";
            totalfiles.Clear();     
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

        private void FileSearch_Load(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
