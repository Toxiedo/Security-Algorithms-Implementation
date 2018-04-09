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
    public partial class AES_Form : Form
    {
        public AES_Form()
        {
            InitializeComponent();
        }

        private void btnTextEncrypt_Click(object sender, EventArgs e)
        {
            AES_Encrypion obj = new AES_Encrypion();
            txtEncrypted.Clear();
            string Output = "";
            string final = "", final1 = "", final2 = "";
            string[] keys = new string[11];
            string cipher =txtKey .Text;
            string state =txtPlainText.Text;
            keys[0] = cipher;
            for (int i = 1; i <= 10; i++)
            {
                keys[i] = obj.GetRound(keys[i - 1], i - 1);
            }
            string output = obj.round(cipher, state);
            for (int i = 0; i < 9; i++)
            {
                final = obj.subbytes_round(output);
                final1 = obj.ShiftRows(final);
                final2 = obj.mix_column(final1);
                output = obj.round(keys[i + 1], final2);
            }
            final = obj.subbytes_round(output);
            final1 = obj.ShiftRows(final);
            Output = obj.round(keys[10], final1);
            string[,] finaloutput = new string[4, 4];
            int c = 0, c1 = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    finaloutput[i, j] = Output[c].ToString() + Output[c1].ToString();
                    c += 2;
                    c1 += 2;
                }
            }
            
            for (int i = 0; i < 4; i++)
            {
                txtEncrypted.Text += "\n";
                for (int j = 0; j < 4; j++)
                {
                    txtEncrypted.Text += finaloutput[i, j] + " ";
                }
                
            }

            
        }

        private void btnTextDecrypt_Click(object sender, EventArgs e)
        {
            AES_Encrypion obj = new AES_Encrypion();
            AES_Decryption objct = new AES_Decryption();
            
            string Output = "";
            string Final = "", Final1 = "", Final2 = "";
            string[] keys = new string[11];
            string cipher =txtKey .Text;
            string state =txtPlainText.Text;
            keys[0] = cipher;
            for (int i = 1; i <= 10; i++)
            {
                keys[i] = obj.GetRound(keys[i - 1], i - 1);
            }
            string output = obj.round(cipher, state);
            for (int i = 0; i < 9; i++)
            {
                Final = AES_Decryption.LeftShift2(output, i);
                Final1 = obj.subbytes_round(Final);
                Final2 = obj.round(keys[i + 1], Final1);
                output = obj.mix_column(Final2);
              
            }
            Final = AES_Decryption.LeftShift2(output,0);
            Final1 = obj.subbytes_round(Final);
        
            Output = obj.round(keys[10], Final1);
            string[,] finaloutput = new string[4, 4];
            int c = 0, c1 = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    finaloutput[i, j] = Output[c].ToString() + Output[c1].ToString();
                    c += 2;
                    c1 += 2;
                }
            }
            
            for (int i = 0; i < 4; i++)
            {
                txtEncrypted.Text += "\n";
                for (int j = 0; j < 4; j++)
                {
                    txtEncrypted.Text += finaloutput[i, j] + " ";
                }
                
            }

            
        }

        }
        }
    

