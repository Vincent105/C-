using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_struct_plus
{
    public partial class Form1 : Form
    {
        struct _CUBOID1
        {
            public int length;
            public int deep;
            public int height;

            public int volume()
            {
                int v;
                v = length * deep * height;
                return v;
            }
        }

        struct _CUBOID2
        {
            static int length = 1;
            static int deep = 1;
            static int height = 1;

            public void setDimension(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }

            public int volume()
            {
                int v;
                v = length * deep * height;
                return v;
            }
        }

        struct _CUBOID3 
        {
            int length;
            int deep;
            int height;

            //結構建構函式
            public _CUBOID3(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }
            public void setDimension(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }

            public int volume()
            {
                int v;
                v = length * deep * height;
                return v;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _CUBOID1 cuboid1;
            int v;

            cuboid1.length = 8;
            cuboid1.deep = 9;
            cuboid1.height = 10;
            v = cuboid1.volume();
            label1.Text = "體積=" + v.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _CUBOID2 cuboid2;
            int v;

            cuboid2.setDimension(l: 5, d : 6, h :7);
            v = cuboid2.volume();
            label1.Text = "體積=" + v.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _CUBOID3 cuboid3;
            int v;

            cuboid3 = new _CUBOID3(3, 4, 5);
            v = cuboid3.volume();
            label1.Text = "體積=" + v.ToString();
        }
    }
}
