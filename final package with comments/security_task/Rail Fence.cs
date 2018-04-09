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
    public partial class Rail_Fence : Form
    {
        public Rail_Fence()
        {
            InitializeComponent();
        }
        int count_col = 0;
        char[,] table;
        int key;
        string plainText;
        char[] encrypt;
        private void button1_Click(object sender, EventArgs e)
        {
            plainText = textBox2.Text;
            plainText = plainText.Replace(" ", string.Empty);
            key = int.Parse(textBox1.Text);
            table = new char[key, plainText.Length];
            encrypt = new char[plainText.Length];
            int count_plain = 0;
            for (int j = 0; j < plainText.Length; j++)
            {
                for (int i = 0; i < key; i++)
                {
                    if (count_plain == plainText.Length)
                    {
                        table[i, j] = '@';
                        break;
                    }
                    table[i, j] = plainText[count_plain];
                    count_plain++;
                }
                if (count_plain == plainText.Length)
                {
                    break;
                }
            }
            if (plainText.Length % 2 != 0)
            {
                count_plain = plainText.Length + 1;
            }
            count_col = count_plain / key;
            int count = 0;
            for (int j = 0; j < plainText.Length; j++)
            {
                for (int i = 0; i < count_col; i++)
                {
                    if (table[j, i] != '@')
                    {
                        encrypt[count] = table[j, i];
                        count++;
                    }
                }
                if (count == plainText.Length)
                {
                    break;
                }
            }
            string encryption = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                encryption += encrypt[i];
            }
            textBox3.Text = encryption;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string decText = textBox2.Text;
            decText = decText.Replace(" ", string.Empty);
            key = int.Parse(textBox1.Text);
            char[,] decTable = new char[key, decText.Length];
            int counterDec = decText.Length;
            if (decText.Length % 2 != 0)
            {
                counterDec++;
            }
            count_col = counterDec / key;
            encrypt = new char[decText.Length];
            int count_dec = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < count_col; j++)
                {
                    if (count_dec == decText.Length)
                    {
                        decTable[i, j] = '@';
                        break;
                    }
                    decTable[i, j] = decText[count_dec];
                    count_dec++;
                }
                if (count_dec == decText.Length)
                {
                    break;
                }
            }
            int count = 0;
            for (int i = 0; i < count_col; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    if (decTable[j, i] != '@')
                    {
                        encrypt[count] = decTable[j, i];
                        count++;
                    }
                }
                if (count == decText.Length)
                {
                    break;
                }
            }
            string encryption = "";
            for (int i = 0; i < decText.Length; i++)
            {
                encryption += encrypt[i];
            }
            textBox4.Text = encryption;
        }
    }
}
