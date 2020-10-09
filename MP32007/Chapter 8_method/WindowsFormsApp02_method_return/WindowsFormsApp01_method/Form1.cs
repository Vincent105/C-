using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float compute()
        {
            float cTemp, fTemp;

            cTemp = Convert.ToSingle(textBox1.Text);
            fTemp = cTemp * 1.8f + 32;

            return fTemp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;

            f =  compute();
            label3.Text = "溫度" + f;
            MessageBox.Show("轉換完畢");
        }
    }
}
