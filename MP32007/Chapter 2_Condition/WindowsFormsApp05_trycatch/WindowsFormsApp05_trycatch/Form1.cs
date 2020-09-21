using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_trycatch
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
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
                textBox1.Text = "";
                return;
            }

            if (age < 18)
            {
                MessageBox.Show("未滿18歲不能購買");
            }
        }
    }
}
