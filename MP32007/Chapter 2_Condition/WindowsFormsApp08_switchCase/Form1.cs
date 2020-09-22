using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp08_switchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bankNo;

            if (e.KeyChar == 13)
            {
                bankNo = textBox1.Text;

                switch (bankNo)
                {
                    case "816":
                        label3.Text = "安泰銀行";
                        break;
                    case "882":
                        label3.Text = "中國信託";
                        break;
                    case "999":
                        label3.Text = "測試銀行";
                        break;
                    default:
                        MessageBox.Show("查無此銀行");
                        label3.Text = "";
                        break;
                    
                }
                label3.Visible = true;
            }

        }
    }
}
