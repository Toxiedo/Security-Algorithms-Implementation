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
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double encryption;
            int p = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);
            int e_ = int.Parse(textBox3.Text);
            int m = int.Parse(textBox4.Text);
            RSAalgo r = new RSAalgo();
            encryption = r.encrypt(p, q, e_, m);
            textBox5.Text = Convert.ToString(encryption);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double decryption;
            int p = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);
            int e_ = int.Parse(textBox3.Text);
            int c = int.Parse(textBox5.Text);
            RSAalgo r = new RSAalgo();
            decryption = r.decrypt(p, q, e_, c);
            textBox4.Text = Convert.ToString(decryption);
        }
    }
}
