﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp07_whilecontrol
{
    public partial class Form1 : Form
    {
        bool fg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            fg = true;

            while (fg == true)
            {
                i++;
                label1.Text = i.ToString();
                System.Threading.Thread.Sleep(10);
                if (i == 1000)
                    i = 0;

                Application.DoEvents();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fg = false;
        }
    }
}
