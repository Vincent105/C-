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
        //偵測按鍵的字元型態，或區分字母大小寫
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label5.Text = Convert.ToString(e.KeyChar);
        }
        //偵測放開按鍵的字元型態
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {          
            label6.Text = Convert.ToString(e.KeyData);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
