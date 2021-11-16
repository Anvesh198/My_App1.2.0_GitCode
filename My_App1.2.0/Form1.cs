using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Configuration;

namespace My_App1._2._0
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
        }
        int c = 1;
        public static string quantity;
        private void button1_Click(object sender, EventArgs e)
        {
            FileSearch f = new FileSearch();
            f.Text = "FileSearch " + c;
            Task_Label.Text = c + " instances are opened ";
            f.Show();
            c += 1;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void version12oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Task_Label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        public void button3_Click(object sender, EventArgs e)
        {
            int count1 = 1;
            foreach (var key in ConfigurationSettings.AppSettings)
            {
                GetFile(ConfigurationManager.AppSettings[key.ToString()],"*.pdf",count1);
                fcount_label.Text = count1 + " Folder Process Completed";
                textBox1.Text += count1+" Files"+c+Environment.NewLine;
                count1++;
            }
        }
        List<string> totalfiles = new List<string>();
        public void GetFile(string path1,string type,int fcount)
        {
            fcount_label.Text = fcount + " Folder Process is Running";
            totalfiles.Clear();
            int count = 0;
            string[] rootpath = new string[] { path1};
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
                    if (Path.GetExtension(rootfolder) == type)
                    {
                        count += 1;
                        totalfiles.Add(count + " " + file);
                    }
                }

            //string path2 = ConfigurationManager.AppSettings["LogPath"];
            //if (File.Exists(path2))
            //{
            //    //writes to file
            //    using (StreamWriter s = new StreamWriter(path2))
            //    {
            //        foreach (string item in totalfiles)
            //        {
            //            s.WriteLine(item + "   Date:" + DateTime.Now);
            //        }
            //        s.WriteLine("-----------------------------------------------");
            //    }
            //}
            //else
            //{
            //    // Create the file.
            //    FileStream fs = File.Create(path2);
            //    using (StreamWriter s = new StreamWriter(path2))
            //    {
            //        foreach (string item in totalfiles)
            //        {
            //            s.WriteLine(item + "   Date:" + DateTime.Now);
            //        }
            //        s.WriteLine("-----------------------------------------------");
            //    }
            //}
            textBox1.Text += totalfiles.Count + " Files " + Environment.NewLine;
        }
        private void fcount_label_Click(object sender, EventArgs e)
        {

        }
    }
}
