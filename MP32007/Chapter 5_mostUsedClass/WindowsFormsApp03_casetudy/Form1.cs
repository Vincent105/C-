using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp03_casetudy
{
    public partial class Form1 : Form
    {
        bool fgKeyUp = true;
        int dBlood = 100, hBlood = 100;
        int dState = 0, hState = 0; //0:放鬆 1:防守 2:攻擊
        Random rd;

        public Form1()
        {
            InitializeComponent();
            rd = new Random();

            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList2.Images[0];

            label1.Text = dBlood.ToString();
            label2.Text = hBlood.ToString();

            this.Width = 800;
            this.Height = 400;
            pictureBox1.Left = 100;
            pictureBox2.Left = 500;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str;
            str = (e.KeyChar).ToString().ToUpper();
            label4.Text = str;

            //判斷遊戲是否結束
            if (dBlood <= 0 || hBlood <= 0)
            {
                e.Handled = true;
                return;
            }

            if (fgKeyUp == true)
            {
                if (str == "A")
                {
                    pictureBox2.Image = imageList2.Images[2];
                    fgKeyUp = false;
                    hState = 2;
                }
                else
                {
                    if (str == "S")
                    {
                        pictureBox2.Image = imageList2.Images[1];
                        fgKeyUp = false;
                        hState = 1;
                    }
                }

                //判斷狀態與得分
                if (dState == 2 && (hState == 0 || hState == 2))
                {
                    hBlood -= 10;
                }

                if (dState == 0 && hState == 2)
                {
                    dBlood -= 10;
                }

                label1.Text = dBlood.ToString();
                label2.Text = hBlood.ToString();

                //判斷win or lose
                if (dBlood <= 0)
                {
                    timer1.Enabled = false;
                    label3.Text = "You Win!";
                    label3.Visible = true;
                }
                else
                {
                    if (hBlood <= 0)
                    {
                        timer1.Enabled = false;
                        label3.Text = "You Lose!!";
                        label3.Visible = true;

                    }

                }
                    
             
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            fgKeyUp = true;
            hState = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dState = rd.Next(0, 5);
            if (dState > 2)
            {
                dState = 1;
            }

            pictureBox1.Image = imageList1.Images[dState];

            //判斷狀態與得分
            if (dState == 2 && (hState == 0 || hState == 2))
            {
                hBlood -= 10;
            }

            if (dState == 0 && hState == 2)
            {
                dBlood -= 10;
            }

            label1.Text = dBlood.ToString();
            label2.Text = hBlood.ToString();

            //判斷win or lose
            if (dBlood <= 0)
            {
                timer1.Enabled = false;
                label3.Text = "You Win!";
                label3.Visible = true;
            }
            else
            {
                if (hBlood <= 0)
                {
                    timer1.Enabled = false;
                    label3.Text = "You Lose!!";
                    label3.Visible = true;

                }

            }
        }

    }
}
