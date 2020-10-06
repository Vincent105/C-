using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp09_dynamic_controller
{
    public partial class Form1 : Form
    {
        TextBox tb = null;
        Button btn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb = new TextBox();
            tb.Location = new Point(0, button1.Location.Y + button1.Height + 20);
            tb.Text = "王曉明";
            tb.Width = 150;
            this.Controls.Add(tb);

            btn = new Button();
            btn.Location = new Point(0, tb.Location.Y + button1.Height + 20);
            btn.Text = "Click me";
            btn.Width = 150;
            this.Controls.Add(btn);

            btn.Click += new EventHandler(MyClick);
        }

        private void MyClick(object sender, EventArgs e)
        {
            MessageBox.Show("動態按鈕");
            this.Controls.Remove(btn);
        }
    }
}
