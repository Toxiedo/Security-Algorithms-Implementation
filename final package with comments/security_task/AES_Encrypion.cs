using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class AES_Encrypion
    {
        //public string subbytes(string s)
        //{
        //    string[,] arr = new string[4, 4];
        //    int c = 0;
        //    string str = "";
        //    while (c < s.Length)
        //    {
        //        char ch1 = s[c];
        //        int x = Convert.ToInt32(ch1.ToString(), 16);
        //        char ch2 = s[c + 1];
        //        int y = Convert.ToInt32(ch2.ToString(), 16);
        //        str += Tables.sbox[x, y];
        //        c += 2;
        //    }
        //    return str;
        //}
        public string subbytes_round(string s)
        {
            int c = 0;
            string str = "";
            while (c < s.Length)
            {
                char ch1 = s[c];
                int x = Convert.ToInt32(ch1.ToString(), 16);
                char ch2 = s[c + 1];
                int y = Convert.ToInt32(ch2.ToString(), 16);
                str += Tables.sbox[x, y];
                c += 2;
            }
            return str;
        }
        public string ShiftRows(string SubByteMatrix)
        {
            string ShiftMat = "";
            for (int i = 0; i < 8; i++)
            {
                ShiftMat += SubByteMatrix[i];
            }
            ShiftMat += SubByteMatrix[10].ToString() + SubByteMatrix[11].ToString() + SubByteMatrix[12].ToString() + SubByteMatrix[13].ToString() + SubByteMatrix[14].ToString() + SubByteMatrix[15].ToString() + SubByteMatrix[8].ToString() + SubByteMatrix[9].ToString()
                            + SubByteMatrix[20].ToString() + SubByteMatrix[21].ToString() + SubByteMatrix[22].ToString() + SubByteMatrix[23].ToString() + SubByteMatrix[16].ToString() + SubByteMatrix[17].ToString() + SubByteMatrix[18].ToString() + SubByteMatrix[19].ToString()
                            + SubByteMatrix[30].ToString() + SubByteMatrix[31].ToString() + SubByteMatrix[24].ToString() + SubByteMatrix[25].ToString() + SubByteMatrix[26].ToString() + SubByteMatrix[27].ToString() + SubByteMatrix[28].ToString() + SubByteMatrix[29].ToString();
            return ShiftMat;
        }
        public string mix_column(string s)
        {
            int c = 0, c1 = 1;
            string[,] str = new string[4, 4];
            string output = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    str[i, j] = s[c].ToString() + s[c1].ToString();
                    c += 2;
                    c1 += 2;
                }
            }
            string h = "";
            for (int i = 0; i < 4; i++)
            {
                string[] arr = { str[0, i], str[1, i], str[2, i], str[3, i] };
                for (int j = 0; j < 4; j++)
                {
                    string[] a = { Tables.mix[j, 0],Tables.mix[j, 1],Tables.mix[j, 2],Tables.mix[j, 3] };
                    h = Xor(arr, a).ToString("X");
                    if (h.Length < 2)
                    {
                        h = h.Insert(0, "0");
                    }
                    output += h;
                }
            }
            string newout = "";
            for (int i = 0; i < 8; i += 2)
            {
                newout += output[i].ToString() + output[i + 1].ToString() + output[i + 8].ToString() + output[i + 9].ToString()
                    + output[i + 16].ToString() + output[i + 17].ToString() + output[i + 24].ToString() + output[i + 25].ToString();
            }
            return newout;
        }
        public int Xor(string[] s, string[] s1)
        {
            int result = 0;
            for (int i = 0; i < 4; i++)
            {
                result ^= Convert.ToInt32(mult(s[i], s1[i]), 16);
            }
            return result;
        }
        public string mult(string s, string s1)
        {
            if (s1 == "01")
            {
                return s;
            }
            else if (s1 == "02")
            {
                int x = Convert.ToInt32(s, 16);
                if (x >= 128)
                {
                    x = x << 1;
                    x = x ^ 0x1b;
                }
                else
                {
                    x = x << 1;
                }
                string str = x.ToString("X");
                if (str.Length > 2)
                {
                    str = str.Substring(1, 2);
                }
                return str;
            }
            else
            {
                int orig = Convert.ToInt32(s, 16);
                int x = Convert.ToInt32(s, 16);
                if (x >= 128)
                {
                    x = x << 1;
                    x = x ^ 0x1b;
                }
                else
                {
                    x = x << 1;
                }
                string str = x.ToString("X");
                if (str.Length > 2)
                {
                    str = str.Substring(1, 2);
                }
                int y = Convert.ToInt32(str, 16);

                return (orig ^ y).ToString("X");
            }

        }
        public string GetRound(string Cipher, int rcon)
        {
            string temp = "";
            string output = "";
            string[,] CipherKey = new string[4, 4];
            int c = 0, c1 = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    CipherKey[i, j] = Cipher[c].ToString() + Cipher[c1].ToString();
                    c += 2;
                    c1 += 2;
                }
            }
            string[,] NewRound = new string[4, 4];
            temp += CipherKey[1, 3] + CipherKey[2, 3] + CipherKey[3, 3] + CipherKey[0, 3];
            string subb;
            subb = subbytes_round(temp);
            string[,] firstCol = new string[4, 1];
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                string o = "";
                o += subb[count] .ToString() + subb[count + 1].ToString();
                firstCol[i, 0] = o;
                count += 2;
            }
            for (int i = 0; i < 4; i++)
            {
                int x = Convert.ToInt32(CipherKey[i, 0], 16);
                int y = Convert.ToInt32(firstCol[i, 0], 16);
                int z = Convert.ToInt32(Tables.Rcon[i, rcon], 16);
                int result = (x ^ y ^ z);
                string o = "";
                o += result;
                string h = result.ToString("X");
                string final = "";
                if (h.Length < 2)
                {
                    h = h.Insert(0, "0");
                }
                final += h;
                NewRound[i, 0] = final;
            }
            for (int j = 1; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    int x = Convert.ToInt32(CipherKey[i, j], 16);
                    int y = Convert.ToInt32(NewRound[i, j - 1], 16);
                    int result = x ^ y;
                    string o = "";
                    o += result;
                    string h = result.ToString("X");
                    string final = "";
                    if (h.Length < 2)
                    {
                        h = h.Insert(0, "0");
                    }
                    final += h;
                    NewRound[i, j] = final;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    output += NewRound[i, j];
                }
            }
            return output;

        }
        public string round(string s, string s1)
        {
            int c = 0, c1 = 1;
            string[,] cipher = new string[4, 4];
            string[,] state = new string[4, 4];
            string output = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cipher[i, j] = s[c].ToString() + s[c1].ToString();
                    state[i, j] = s1[c].ToString() + s1[c1].ToString();
                    c += 2;
                    c1 += 2;
                }
            }
            string h = "";
            for (int i = 0; i < 4; i++)
            {
                string[] arr = { cipher[i, 0], cipher[i, 1], cipher[i, 2], cipher[i, 3] };
                string[] a = { state[i, 0], state[i, 1], state[i, 2], state[i, 3] };
                for (int j = 0; j < 4; j++)
                {
                    h = StXor(arr[j], a[j]).ToString("X");
                    if (h.Length < 2)
                    {
                        h = h.Insert(0, "0");
                    }
                    output += h;
                }
            }
            return output;
        }
        public int StXor(string s, string s1)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(s, 16);
            y = Convert.ToInt32(s1, 16);
            return (x ^ y);
        }
    }
}
