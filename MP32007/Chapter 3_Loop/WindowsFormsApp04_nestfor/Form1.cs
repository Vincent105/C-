﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp04_nestfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            int p;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    p = i * j;

                    str += i.ToString() + "x" + j.ToString() + "=" + p.ToString() + "\t";
                }
                textBox1.AppendText(str + "\r\n");
                str = "";
            }
        }
    }
}
