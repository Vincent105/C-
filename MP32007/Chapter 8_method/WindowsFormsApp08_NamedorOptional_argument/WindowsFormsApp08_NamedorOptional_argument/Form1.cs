using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp08_NamedorOptional_argument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float top, bottom, ht;
            float area;

            top = Convert.ToSingle(textBox1.Text);
            bottom = Convert.ToSingle(textBox2.Text);
            ht = Convert.ToSingle(textBox3.Text);

            area = trapezozid(tBase: top, bBase: bottom, height: ht);
            label4.Text = "area=" + area.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float area;

            area = trapezozid(height: 40, bBase: 50);
            label4.Text = "area=" + area.ToString();

        }

        float trapezozid(float tBase = 15, float bBase = 20, float height = 10)
        {
            float area;

            area = (tBase + bBase) * height / 2.0f;

            return area;
        }
    }
}
