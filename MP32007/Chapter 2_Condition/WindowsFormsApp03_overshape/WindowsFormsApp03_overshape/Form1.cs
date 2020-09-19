using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp03_overshape
{
    public partial class Form1 : Form
    {
        int move = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ovalShape1.Left <= 0)
                move = -move;
            if (ovalShape1.Left + ovalShape1.Width >= ClientSize.Width)
                move = -move;
            ovalShape1.Left += move;
        }
    }
}
