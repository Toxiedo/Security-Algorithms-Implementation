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
    public partial class Des : Form
    {
        public Des()
        {
            InitializeComponent();
        }

       
    

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cipher = textBox1.Text;
            string key = textBox2.Text;
            DESalgo k = new DESalgo();
            string plain = k.DesDecryption(key, cipher);
            textBox3.Text = plain;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string plain = textBox1.Text;
            string key = textBox2.Text;
            DESalgo k = new DESalgo();
            string cipher = k.DesEncrypttion(key, plain);
            textBox3.Text = cipher;
        }

        }
    }

