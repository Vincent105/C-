﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05

{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Text = e.KeyCode.ToString();
            label7.Text = e.KeyValue.ToString();
            label8.Text = e.KeyData.ToString();

            label14.Text = Convert.ToString(++count);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //可以判別大小寫
            label5.Text = Convert.ToString(e.KeyChar);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //按鍵放開時才會異動
            label6.Text = Convert.ToString(e.KeyData);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
