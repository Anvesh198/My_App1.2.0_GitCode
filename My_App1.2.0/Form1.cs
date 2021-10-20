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
namespace My_App1._2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
          FileSearch f = new FileSearch();
          f.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void version12oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
