using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_Mouse
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "MouseDown";
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "MouseUp";
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "MouseEnter";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "MouseLeave";
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseClick";
        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseDoubleClick";
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "MouseMove";
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "MouseHover";
        }
    }
}
