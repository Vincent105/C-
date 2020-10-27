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
using System.Linq.Expressions;

namespace WindowsFormsApp1_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath;
            DirectoryInfo di;

            strPath = "MyDir\\subdir";

            string str = System.Environment.CurrentDirectory;

            try
            {
                if (Directory.Exists(strPath))
                {
                    MessageBox.Show("目錄已存在");
                    MessageBox.Show(str);
                    return;
                }
                di = Directory.CreateDirectory(strPath);
                MessageBox.Show("目錄建立完成");
            }
            catch (IOException ex)
            {
                MessageBox.Show("建立目錄錯誤");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
