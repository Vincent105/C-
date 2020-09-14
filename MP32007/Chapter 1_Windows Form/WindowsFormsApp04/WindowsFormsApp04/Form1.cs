using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int instNum, sodaNum;
            int instPrice = 50 , sodaPrice = 100;
            int totalPrice;

            instNum = Convert.ToInt32(textBox1.Text);
            sodaNum = Convert.ToInt32(textBox2.Text);

            totalPrice = instNum * instPrice + sodaNum * sodaPrice;
            label3.Text = Convert.ToString(totalPrice);


        }
    }
}
