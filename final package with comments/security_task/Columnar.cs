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
    public partial class Columnar : Form
    {
        public Columnar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = textBox2.Text;
            plainText = plainText.Replace(" ", string.Empty);
            string key = textBox1.Text;
            key = key.Replace(" ", string.Empty);
            char[,] table = new char[plainText.Length, key.Length];
            char[] encrypt;
            int count_plain = 0;
            int count_row = 0;
            for (int j = 0; j < plainText.Length; j++)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (count_plain == plainText.Length)
                    {
                        table[j, i] = 'x';
                        break;
                    }
                    table[j, i] = plainText[count_plain];
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
            encrypt = new char[count_plain];
            count_row = count_plain / key.Length;
            int s = key.Length - 1;
            int index, keys, count = 0;
            for (int k = 0; k < key.Length; k++)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    keys = (int)Char.GetNumericValue(key[i]);
                    if (keys == (key.Length - s))
                    {
                        index = i;
                        for (int j = 0; j < count_row; j++)
                        {
                            encrypt[count] += table[j, index];
                            count++;
                        }
                        s--;
                    }

                }
            }
            string encryption = "";
            for (int i = 0; i < count_plain; i++)
            {
                encryption += encrypt[i];
            }
            textBox3.Text = encryption;
            
        }

        private void decryption_Click(object sender, EventArgs e)
        {
            string decText = textBox2.Text;
            decText = decText.Replace(" ", string.Empty);
            string key = textBox1.Text;
            int row = decText.Length / key.Length;
            char[,] decTable = new char[row, key.Length];
            int s = key.Length - 1;
            int index, keys, count = 0;
            for (int k = 0; k < key.Length; k++)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    keys = (int)Char.GetNumericValue(key[i]);
                    if (keys == (key.Length - s))
                    {
                        index = i;
                        for (int j = 0; j < row; j++)
                        {
                            decTable[j, i] = decText[count];
                            count++;
                        }
                        s--;
                    }
                }
            }
            int count1 = 0;
            string decryption = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    decryption += decTable[i, j];
                    count1++;
                }
                if (count1 == decText.Length)
                {
                    break;
                }
            }
            textBox4.Text = decryption;
        }
    }
}
