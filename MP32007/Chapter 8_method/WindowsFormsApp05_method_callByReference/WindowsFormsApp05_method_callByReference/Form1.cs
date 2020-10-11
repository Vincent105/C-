using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_method_callByReference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            label4.Text = a.ToString();
            add(ref a);
            label6.Text = a.ToString();
        }

        void add(ref int a)
        {
            a += 5;
            label5.Text = a.ToString();
        }
    }
}
