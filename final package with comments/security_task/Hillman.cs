using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security_task
{
    public partial class Hillman : Form
    {
        public Hillman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Q = Convert.ToInt32(textBox1.Text);
            double Alpha = Convert.ToInt32(textBox2.Text);
            double Xa = Convert.ToInt32(textBox3.Text);
            double Xb = Convert.ToInt32(textBox4.Text);
            hellman h = new hellman();
            h.exchange_key(Q, Alpha, Xa, Xb);
            textBox5.Text = h.key_a.ToString();
            textBox6.Text = h.key_b.ToString();
        }
    }
}
