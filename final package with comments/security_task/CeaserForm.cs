﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security_task
{
    public partial class CeaserForm : Form
    {
        Ceaser c = new Ceaser();
        public CeaserForm()
        {
            c.FilList();
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string PlainText = textBox1.Text;
            PlainText = PlainText.Replace(" ", string.Empty);
            int key =int.Parse(textBox3.Text);
            char[] cipher = new char[PlainText.Length];
            cipher = c.en(PlainText,key);
            string s = new string(cipher);
            textBox2.Text = s;
            
        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            string CI = textBox1.Text;
            CI= CI.Replace(" ", string.Empty);
            int key = int.Parse(textBox3.Text);
            char[] P = new char[CI.Length];
            P = c.DE(CI, key);
            string s = new string(P);
            textBox2.Text = s;
        }
    }
}
