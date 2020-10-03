using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_delete_array
{
    public partial class Form1 : Form
    {
        int[] array = { 4, 12, 87, 45, 14, 13, 56, 9, 33, 6, 21, 8 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no = -1;    //表示沒有找到
            int val, j = 0; //使用者輸入的數值，臨時陣列的長度
            int [] tmp;      //臨時陣列
            int length, new_length; //原始陣列長度，新的陣列長度

            val = Convert.ToInt32(textBox1.Text);
            length = array.Length;

            for (int i = 0; i < length; i++)
                if (array[i] == val)
                {
                    no = i;
                    break;
                }
            if (no == -1)
            {
                MessageBox.Show("沒有找到");
                return;
            }
            textBox2.AppendText("原始陣列長度" + array.Length.ToString() + "\r\n");
            new_length = length - 1;
            tmp = new int[new_length];

            for (int i = 0; i < length; i++)
            {
                if (i == no)
                    continue;
                tmp[j] = array[i];
                j++;
            }

            for (int i = 0; i < new_length; i++)
            {
                array[i] = tmp[i];
            }

            Array.Resize(ref array, new_length);

            foreach (var item in array)
                textBox2.AppendText(item.ToString() + "\r\n");

            textBox2.AppendText("陣列長度" + array.Length.ToString() + "\r\n");
        }
    }
}
