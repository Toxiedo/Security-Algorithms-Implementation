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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CeaserForm s = new CeaserForm();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formx f = new Formx();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hill_Cipher f = new Hill_Cipher();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rail_Fence f = new Rail_Fence();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Columnar f = new Columnar();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Polyalphabetic_FORM s = new Polyalphabetic_FORM();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           playfair p = new playfair();
            p.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MULINVERSE m = new MULINVERSE();
            m.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AES_Form a = new AES_Form();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Des d = new Des();
            d.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RC4Form R = new RC4Form();
            R.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hillman h = new Hillman();
            h.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RSA S = new RSA();
            S.Show();
        }


        
    }
}
