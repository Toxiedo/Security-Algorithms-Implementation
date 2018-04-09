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
    public partial class RC4Form : Form
    {
        public RC4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = textBox1.Text;
            plaintext = plaintext.Replace(" ", string.Empty);
           
            string key = textBox2.Text;
            key = key.Replace(" ", string.Empty);
            
            byte[] encryption_res = new byte[256];
            RC4_algo r = new RC4_algo();
            encryption_res = r.encryption(plaintext, key);
            string CT = "";
            for (int i = 0; i < encryption_res.Length; i++)
                CT += (char)encryption_res[i];
            textBox3.Text = CT;

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            key = key.Replace(" ", string.Empty);
            string CT = textBox3.Text;
       
            byte[] decryption_res = new byte[256];
            RC4_algo r = new RC4_algo();
            decryption_res = r.decryption(CT, key);

            string PT = "";
            for (int i = 0; i < decryption_res.Length; i++)
             PT += (char)decryption_res[i];
            textBox1.Text = PT;
        }

       


    }
}
