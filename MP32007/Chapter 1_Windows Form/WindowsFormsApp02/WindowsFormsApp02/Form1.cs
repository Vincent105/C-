using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caption, text, str;
            int age;
            DialogResult dialogResult;

            text = textBox1.Text;
            caption = textBox2.Text;
            str = "今年" + textBox3.Text.ToString() + "歲";

            dialogResult = MessageBox.Show(str, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            label3.Visible = true;
            label3.Text = dialogResult.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
