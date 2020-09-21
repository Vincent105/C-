using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp04_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(textBox1.TabIndex);

            if (age < 18)
            {
                MessageBox.Show("未滿18歲不可購買");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)48 || e.KeyChar == (char)49 ||
                e.KeyChar == (char)50 || e.KeyChar == (char)51 ||
                e.KeyChar == (char)52 || e.KeyChar == (char)53 ||
                e.KeyChar == (char)54 || e.KeyChar == (char)55 ||
                e.KeyChar == (char)56 || e.KeyChar == (char)57 ||
                e.KeyChar == (char)13 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
