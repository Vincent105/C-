using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp07_ifelseNest
{
    public partial class Form1 : Form
    {
        int gender = 0;
        bool fgVel = false;
        bool fgHDC = false;
        int age = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
            groupBox2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = 0;
            groupBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fgHDC = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            fgHDC = false;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            fgVel = true;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            fgVel = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "0";
                return;
            }
            if (gender == 0)
            {
                if (age < 25 || age > 35)
                {
                    MessageBox.Show("年齡不符合");
                }
                else
                {
                    if (fgVel == true)
                    {
                        MessageBox.Show("資格符合");
                    }
                    else
                        MessageBox.Show("沒有交通工具，資格不符合");

                }
            }
            else
            {
                if (fgHDC == false)
                    MessageBox.Show("尚未役畢，");
                else
                {
                    if (age < 25 || age > 35)
                        MessageBox.Show("年齡不符合");
                    else
                    {
                        if (fgVel == true)
                        {
                            MessageBox.Show("資格符合");
                        }
                        else
                            MessageBox.Show("沒有交通工具，資格不符合");

                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
