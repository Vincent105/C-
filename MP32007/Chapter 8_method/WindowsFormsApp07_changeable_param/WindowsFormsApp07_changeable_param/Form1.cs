using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp07_changeable_param
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fee;
            fee = compute(1, 3, 4);
            label1.Text = "Wang: " + fee.ToString();

            fee = compute(2, 4);
            label2.Text = "Esther: " + fee.ToString();
        }

        int compute(params int [] days)
        {
            double fee = 0;


            for (int i = 0; i < days.Length; i++)
            {
                switch (days[i])
                {
                    case 6:
                    case 7:
                        fee += 500;
                        break;
                    case 1:
                    case 5:
                        fee += 500 * 0.7;
                        break;
                    case 2:
                        fee += 500 * 0.85;
                        break;
                    case 3:
                    case 4:
                        fee += 500 * 0.8;
                        break;
                }
                
            }
            return Convert.ToInt32(Math.Round(fee, MidpointRounding.AwayFromZero));
        }
    }
}
