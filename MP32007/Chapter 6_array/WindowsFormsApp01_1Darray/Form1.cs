using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01_1Darray
{
    public partial class Form1 : Form
    {
        int[] score = new int[5];
        bool fgOK = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[0] = Convert.ToInt32(textBox1.Text);
                fgOK = true;
                if (score[0] < 60)
                    textBox1.ForeColor = Color.Red;
                else
                    textBox1.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[1] = Convert.ToInt32(textBox2.Text);
                fgOK = true;
                if (score[1] < 60)
                    textBox2.ForeColor = Color.Red;
                else
                    textBox2.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[2] = Convert.ToInt32(textBox3.Text);
                fgOK = true;
                if (score[2] < 60)
                    textBox3.ForeColor = Color.Red;
                else
                    textBox3.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[3] = Convert.ToInt32(textBox4.Text);
                fgOK = true;
                if (score[3] < 60)
                    textBox4.ForeColor = Color.Red;
                else
                    textBox4.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[4] = Convert.ToInt32(textBox5.Text);
                fgOK = true;
                if (score[4] < 60)
                    textBox5.ForeColor = Color.Red;
                else
                    textBox5.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                string str;

                if (fgOK == false)
                    return;
                textBox1.Clear();

                for (int i = 0; i < 5; i++)
                {
                    str = "第" + (i + 1).ToString() + "筆成績=" + score[i].ToString();
                    textBox6.AppendText(str + "\r\n");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float avg = 0;
            if (fgOK == false)
            {
                MessageBox.Show("成績輸入有誤");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                avg += score[i];
            }

            avg /= 5.0f;
            label6.Text = "平均=" + avg.ToString();
           
        }
    }
}
