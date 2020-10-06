using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp08_irregular_array
{
    public partial class Form1 : Form
    {
        int[] stu_sum = { 3, 2, 4 };
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;
                   
            }

            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].Width = 70;

            dataGridView1.Rows[0].Cells[0].Value = "一";
            dataGridView1.Rows[1].Cells[0].Value = "二";
            dataGridView1.Rows[2].Cells[0].Value = "三";

            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows[0].Cells[4].ReadOnly = true;
            dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.LightGray;

            for (int i = 3; i <= 4; i++)
            {
                dataGridView1.Rows[1].Cells[i].ReadOnly = true;
                dataGridView1.Rows[1].Cells[i].Style.BackColor = Color.LightGray;
            }

            //初始化
            for (int i = 0; i < 3; i++)
                for (int j = 1; j <= stu_sum[i]; j++)
                    dataGridView1.Rows[i].Cells[j].Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] clas = new int[3][];
            Single avg;

            clas[0] = new int[3];
            clas[1] = new int[2];
            clas[2] = new int[4];

            try
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < stu_sum[i]; j++)
                        clas[i][j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                avg = 0;
                for (int j = 0; j < stu_sum[i]; j++)
                    avg += clas[i][j];

                avg = avg / stu_sum[i];
                dataGridView1.Rows[i].Cells[5].Value = avg;
            }
        }
    }
}
