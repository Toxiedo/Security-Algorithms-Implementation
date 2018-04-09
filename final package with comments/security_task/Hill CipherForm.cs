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
    public partial class Hill_Cipher : Form
    {
        public Hill_Cipher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = richTextBox1.Lines.Length;
            int m = Convert.ToInt32(textBox1.Text);
            List<int> mvalues = new List<int>();
            for (int i = 0; i < count; i++)
            {
                string[] parts = richTextBox1.Lines[i].Split(' ');
                for (int g = 0; g < parts.Length; g++)
                {
                    mvalues.Add(Convert.ToInt32(parts[g]));
                }
            }
            hill_cipher hc = new hill_cipher();
            int[,] ma = new int[m, m];
            List<char> r = new List<char>();

            string PlainText = textBox2.Text;
            PlainText = PlainText.Replace(" ", string.Empty);
            ma = hc.keymatrix(m, mvalues);
            r = hc.encrpthill(PlainText, m, ma);
            string cipher = " ";
            for (int i = 0; i < r.Count; i++)
            {
                cipher = cipher + r[i];
            }
            textBox3.Text = cipher;
            //  double [,] det=new double[3,3];
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = richTextBox1.Lines.Length;
            hill_cipher hc = new hill_cipher();
            List<char> r2 = new List<char>();
            int m = Convert.ToInt32(textBox1.Text);
            List<int> mvalues = new List<int>();
            for (int i = 0; i < count; i++)
            {
                string[] parts = richTextBox1.Lines[i].Split(' ');
                for (int g = 0; g < parts.Length; g++)
                {
                    mvalues.Add(Convert.ToInt32(parts[g]));
                }
            }
            int[,] ma = new int[m, m];
            ma = hc.keymatrix(m, mvalues);
            string PlainText = textBox2.Text;
            PlainText = PlainText.Replace(" ", string.Empty);
            r2 = hc.decrpthill(PlainText, ma, m);
            string cipher2 = " ";
            for (int i = 0; i < r2.Count; i++)
            {
                cipher2 = cipher2 + r2[i];
            }
            textBox4.Text = cipher2;
        }
    }
}
