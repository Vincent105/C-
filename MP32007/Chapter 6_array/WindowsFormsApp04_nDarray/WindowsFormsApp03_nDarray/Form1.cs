using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp03_nDarray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //增加三列，並設定
            for (int i = 0; i <= 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;
            }
            //設定平均列唯讀
            dataGridView1.Rows[3].ReadOnly = true;

            //設定欄位寬度
            for (int i = 0; i <= 5; i++)
            {
                dataGridView1.Columns[i].Width = 70;
            }

            //設定整體dataGridView1的寬與高
            dataGridView1.Width = dataGridView1.Columns[0].Width * 7;
            dataGridView1.Height = dataGridView1.Rows[0].Height * 6;

            dataGridView1.Rows[0].Cells[0].Value = "CTM601";
            dataGridView1.Rows[1].Cells[0].Value = "CTM507";
            dataGridView1.Rows[2].Cells[0].Value = "CTM521";
            dataGridView1.Rows[3].Cells[0].Value = "平均";

            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.LightGray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] rev = new int[3, 4];
            Single avg;

            try
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                        rev[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入字串有誤");
                return;
            }
            //計算個人總平均
            for (int i = 0; i < 3; i++)
            {
                avg = 0.0f;

                for (int j = 0; j < 4; j++)
                    avg += rev[i, j];
                avg /= 4.0f;
                dataGridView1.Rows[i].Cells[5].Value = avg.ToString();

            }

            //計算各月總平均
            for (int i = 0; i < 4; i++)
            {
                avg = 0.0f;

                for (int j = 0; j < 3; j++)
                    avg += rev[j, i];
                avg /= 3.0f;
                dataGridView1.Rows[3].Cells[i + 1].Value = avg.ToString();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
