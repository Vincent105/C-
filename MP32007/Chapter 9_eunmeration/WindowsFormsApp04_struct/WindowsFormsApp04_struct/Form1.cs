using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp04_struct
{
    public partial class Form1 : Form
    {
        public const int MAX_NUM = 3;
        struct _STU
        {
            public int id;
            public string name;
            public int age;
            public int chin;
            public int eng;
            public int math;            
        }

        _STU[] stut = new _STU[MAX_NUM];
        int stuNum;

        void initial()
        {
            stuNum = 0;

            for (int i = 0; i < MAX_NUM; i++)
            {
                stut[i].id = i + 1;
                stut[i].name = "None";
                stut[i].age = 0;
                stut[i].chin = 0;
                stut[i].eng = 0;
                stut[i].math = 0;
            }
        }

        //清除資料
        void clear()
        {
            textBox1.Text = "無名氏";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

            comboBox1.SelectedIndex = 0;
            
        }

        void add()
        {
            stut[stuNum].id = stuNum + 1;
            stut[stuNum].name = textBox1.Text;
            stut[stuNum].age = Convert.ToInt32(comboBox1.Text);
            stut[stuNum].chin = Convert.ToInt32(textBox2.Text);
            stut[stuNum].eng = Convert.ToInt32(textBox3.Text);
            stut[stuNum].math = Convert.ToInt32(textBox4.Text);

            label2.Text = stut[stuNum].id.ToString();
            stuNum++;
            showData(stuNum);
        }

        void showData(int no)
        {
            string str = "";
            no--;
            str = string.Format("新增學號:{0},姓名:{1},年齡:{2},國文:{3},英文:{4},數學:{5}\r\n"
                , stut[no].id, stut[no].name,stut[no].age, stut[no].chin, stut[no].eng, stut[no].math);

            textBox7.AppendText(str);
        }

        float[] compute(_STU[] stut, float[] avg)
        {
            float[] avg1 = new float[3];

            //計算個人
            for (int i = 0; i < stut.Length; i++)
            {
                avg[i] += stut[i].chin + stut[i].eng + stut[i].math;
                avg[i] /= 3.0f;
            }

            for (int i = 0; i < stut.Length; i++)
            {
                avg1[0] += stut[i].chin;
                avg1[1] += stut[i].eng;
                avg1[2] += stut[i].math;
            }

            for (int i = 0; i < avg1.Length; i++)
                avg1[i] /= 3.0f;

            return avg1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stuNum + 1 > 3)
                MessageBox.Show("人數已滿");
            else
                add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[] avg = { 0, 0, 0 };
            float[] avg1;
            string str ="";
            avg1 = compute(stut, avg);

            str = "[三人平均]";
            for (int i = 0; i < stut.Length; i++)
                str += string.Format("{0}={1:###.##},", stut[i].name, avg[i]);
            
            textBox7.AppendText(str + "\r\n");

            str = string.Format("[三科平均] 國文={0:###.##},英文={1:###.##},數學={2:###.##}"
                , avg1[0], avg1[1], avg1[2]);

            textBox7.AppendText(str + "\r\n");

        }
    }
}
