using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx =-10;
        int vy =10;
        string kao ="(・-・)";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          label1.Left +=vx;
          label1.Top += vy;

          string t = label1.Text;
          label1.Text = kao;
          kao = t;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "vx";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "vy";
        }
    }
}
