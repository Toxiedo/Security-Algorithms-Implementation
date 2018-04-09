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
    public partial class Formx : Form
    {
         Encryptionclass c = new Encryptionclass();
           
        public Formx()
        {
            c.FilList();
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {

            string PlainText = textBox1.Text;
            PlainText = PlainText.Replace(" ", string.Empty);
            char [] cipher = new char[PlainText.Length];
            cipher =c.n(PlainText);
            string s = new string(cipher);
           textBox2.Text = s;
            
        }

        private void Decryption_Click(object sender, EventArgs e)
        {

            string Ci = textBox1.Text;
            Ci = Ci.Replace(" ", string.Empty);
            char[] Di = c.D(Ci);;
            string x = new string(Di);
            textBox2.Text = x;



        }
    }
}
