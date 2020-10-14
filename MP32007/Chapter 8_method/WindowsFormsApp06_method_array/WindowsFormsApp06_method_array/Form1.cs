using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_method_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] stu = new int[3, 3];
            float[] avg;
            string str;
            textBox1.Clear();

            avg = compute(stu);

            for (int i = 0; i < stu.GetLength(0); i++)
            {
                str = string.Format("第{0}位學生的國文{1}英文{2}數學{3}，平均{4}", i + 1, stu[i, 0], stu[i, 1], stu[i, 2], avg[i]);

                textBox1.AppendText(str + "\r\n");
            }
        }

        float[] compute(int[,] stu)
        {
            float[] avg = { 0, 0, 0 };
            Random rd = new Random();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    stu[i, j] = rd.Next(41) + 60;
                }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    avg[i] += stu[i, j];
                avg[i] /= 3.0f;
            }

            return avg;
        }
    }
}
