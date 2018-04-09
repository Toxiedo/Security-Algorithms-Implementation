using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class RC4_algo
    {
        public byte[] encryption(string plaintext, string key)
        {
            byte[] PT_arr = new byte[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                PT_arr[i] = (byte)plaintext[i];

            }
            byte[] key_arr = new byte[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                key_arr[i] = (byte)key[i];
            }
            byte[] S = new byte[256];
            byte[] T = new byte[256];
            byte[] CT = new byte[plaintext.Length];
            byte[] t = new byte[plaintext.Length];
            //////////////////////Initialization//////////////////
            for (int i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
                T[i] = key_arr[i % key.Length];
            }
            ///////////Initial Permutations///////////////////////
            byte temp;
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) % 256;
                temp = S[i];
                S[i] = S[j];
                S[j] = temp;
            }
            //////////////////stream generator/////////////////
            int k = 0;
            int y = 0;
            for (int x = 0; x < plaintext.Length; x++)
            {

                k = (k + 1) % 256;
                y = (y + S[k]) % 256;
                temp = S[k];
                S[k] = S[y];
                S[y] = temp;
                t[x] = S[(S[k] + S[y]) % 256];
                CT[x] = (byte)(plaintext[x] ^ t[x]);
            }

            return CT;
        }
        public byte[] decryption(string CT, string key)
        {
            byte[] key_arr = new byte[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                key_arr[i] = (byte)key[i];
            }
            byte[] CT_arr = new byte[CT.Length];
            for (int i = 0; i < CT.Length; i++)
            {
                CT_arr[i] = (byte)CT[i];
            }


            byte[] S = new byte[256];
            byte[] T = new byte[256];
            byte[] PT = new byte[CT_arr.Length];
            byte[] t = new byte[CT_arr.Length];
            //////////////////////Initialization//////////////////
            for (int i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
                T[i] = key_arr[i % key_arr.Length];
            }
            ///////////Initial Permutations///////////////////////
            byte temp;
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) % 256;
                temp = S[i];
                S[i] = S[j];
                S[j] = temp;
            }
            //////////////////stream generator/////////////////
            int k = 0;
            int y = 0;
            for (int x = 0; x < CT_arr.Length; x++)
            {

                k = (k + 1) % 256;
                y = (y + S[k]) % 256;
                temp = S[k];
                S[k] = S[y];
                S[y] = temp;
                t[x] = S[(S[k] + S[y]) % 256];
                PT[x] = (byte)(CT[x] ^ t[x]);
            }

            return PT;
        }

    }
}
