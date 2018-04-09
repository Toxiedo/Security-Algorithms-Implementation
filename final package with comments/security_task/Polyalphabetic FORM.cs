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
    public partial class Polyalphabetic_FORM : Form
    {
        Encryption en = new Encryption();
        public Polyalphabetic_FORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox3.Text;
            string P_T = textBox1.Text;
            P_T = P_T.Replace(" ", string.Empty);
            int Typ = int.Parse(textBox4.Text);
            string C_T = new string(en.Process(keyword, Typ, P_T));
            textBox2.Text = C_T;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = textBox3.Text;

            string P_T = textBox2.Text;
            P_T = P_T.Replace(" ", string.Empty);
            int Typ = int.Parse(textBox4.Text);
            string C_T = new string(en.Process1(keyword, Typ, P_T));
            textBox1.Text = C_T;
           
        }
    }
}
