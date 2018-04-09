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
    public partial class MULINVERSE : Form
    {
        public MULINVERSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int mulinverse1 = 0;
            mul_inverse M = new mul_inverse();
            int mulinverse = M.mulinverse(m, n);
            textBox3.Text = Convert.ToString(mulinverse);
            if (mulinverse < 0)
            {
                mulinverse1 = mulinverse + 26;//////  bgm3 26  3lashan  ageb el modules//////
            }
            else
            {
                mulinverse1 = mulinverse % 26;
            }
            textBox4.Text = Convert.ToString(mulinverse1);
        }
    }
}
