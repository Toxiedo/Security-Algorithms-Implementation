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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[,] table = new char[5, 5];
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;

            char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string fullText;
            string encryption;
            string inputText = textBox1.Text;
            inputText = inputText.Replace(" ", string.Empty);
            string plainText = textBox2.Text;
            plainText = plainText.Replace(" ", string.Empty);
            ////////////////////////string elli hatmleeh fel table////////////////////////////
            string keyword = Convert.ToString(inputText[0]);
            for (int i = 1; i < inputText.Length; i++)
            {
                for (int j = 0; j < keyword.Length; j++)
                {
                    if (inputText[i] == keyword[j])
                    {
                        flag = false;
                        j = keyword.Length;
                    }
                    else
                        flag = true;
                }
                if (flag == true)
                {
                    keyword += inputText[i];
                }
            }
            fullText = Convert.ToString(keyword[0]);
            for (int i = 1; i < keyword.Length; i++)
            {
                fullText += keyword[i];
            }

            flag = true;
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < keyword.Length; j++)
                {
                    if (alpha[i] == 'i' || alpha[i] == 'j')
                    {
                        if (keyword[j] == 'i' || keyword[j] == 'j')
                        {
                            flag = false;
                        }
                    }
                    else if (alpha[i] == keyword[j])
                    {
                        flag = false;
                        j = keyword.Length;
                    }
                    else
                        flag = true;
                }
                if (flag == true)
                {
                    fullText += alpha[i];
                }
            }
            ///////////////////////////fill matrices//////////////////////////////////
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    table[i, j] = fullText[c];
                    c++;
                }
            }
            ///////////////////////////encrypt row//////////////////////

            string pt = "";
            for (int p = 0; p < plainText.Length; p++)
            {
                pt += plainText[p];
                if (p + 1 == plainText.Length)
                    break;
                if (plainText[p] == 'x' && plainText[p + 1] == 'x')
                {
                    pt += 'a';
                }
                else if (plainText[p] == plainText[p + 1])
                {
                    pt += 'x';
                }
            }
            if (pt.Length % 2 != 0)
            {
                if (pt[pt.Length] == 'x')
                    pt += 'a';
                else
                    pt += 'x';
            }
            encryption = "";
            string sub = "";
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, count = 0;
            for (int i = 0; i < pt.Length; i = i + 2)
            {
                sub = pt.Substring(i, 2);
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (table[j, k].Equals(sub[0]))
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if (table[j, k].Equals(sub[1]))
                        {
                            x2 = j;
                            y2 = k;
                        }


                    }
                }

                if (x1 == x2)
                {
                    if (y1 == 4)
                        y1 = -1;
                    else if (y2 == 4)
                        y2 = -1;
                    encryption += table[x1, y1 + 1];
                    count++;
                    encryption += table[x2, y2 + 1];
                    count++;
                }
                /////////////////////////////////encrypt col////////////////////////////////
                else if (y1 == y2)
                {
                    if (x2 == 4)
                        x2 = -1;
                    else if (x1 == 4)
                        x1 = -1;
                    encryption += table[x1 + 1, y1];
                    count++;
                    encryption += table[x2 + 1, y2];
                    count++;
                }
                ////////////////////////////////encrypt square///////////////////////////
                else
                {
                    encryption += table[x1, y2];
                    count++;
                    encryption += table[x2, y1];
                    count++;
                }
            }

            textBox3.Text = encryption;
            /////////////////////////////////////decryption///////////////////////////////

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string decryption;
            string decText = textBox2.Text;
            decText = decText.Replace(" ", string.Empty);
            string dt = "";
            for (int p = 0; p < decText.Length; p++)
            {
                dt += decText[p];
                if (p + 1 == decText.Length)
                    break;
                if (decText[p] == 'x' && decText[p + 1] == 'x')
                {
                    dt += 'a';
                }
                else if (decText[p] == decText[p + 1])
                {
                    dt += 'x';
                }
            }
            if (dt.Length % 2 != 0)
            {
                if (dt[dt.Length] == 'x')
                    dt += 'a';
                else
                    dt += 'x';
            }
            decryption = "";
            string sub = "";
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, count = 0;
            for (int i = 0; i < dt.Length; i = i + 2)
            {
                sub = dt.Substring(i, 2);
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (table[j, k].Equals(sub[0]))
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if (table[j, k].Equals(sub[1]))
                        {
                            x2 = j;
                            y2 = k;
                        }


                    }
                }

                if (x1 == x2)
                {
                    if (y1 == 0)
                        y1 = 5;
                    else if (y2 == 0)
                        y2 = 5;
                    decryption += table[x1, y1 - 1];
                    count++;
                    decryption += table[x2, y2 - 1];
                    count++;
                }
                /////////////////////////////////encrypt col////////////////////////////////
                else if (y1 == y2)
                {
                    if (x2 == 0)
                        x2 = 5;
                    else if (x1 == 0)
                        x1 = 5;
                    decryption += table[x1 - 1, y1];
                    count++;
                    decryption += table[x2 - 1, y2];
                    count++;
                }
                ////////////////////////////////encrypt square///////////////////////////
                else
                {
                    decryption += table[x1, y2];
                    count++;
                    decryption += table[x2, y1];
                    count++;
                }

            }
            textBox4.Text = decryption;
        }
    }
}
