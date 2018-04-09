using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class BasicOperations
    {
        public string ConvertStringToHex(string Text)
        {
            int ASCII1 = 0, ASCII2 = 0;
            string HEX = "";
            for (int i = 0; i < Text.Length / 2; i++)
            {
                ASCII1 = (int)(Text[i]);
                HEX += ASCII1.ToString("X");
            }
            for (int i = Text.Length / 2; i < Text.Length; i++)
            {
                ASCII2 = (int)(Text[i]);
                HEX += ASCII2.ToString("X");
            }
            return HEX;
        }
        public string HexAsciiConvert(string Hex)
        {

            StringBuilder s = new StringBuilder();

            for (int i = 0; i <= Hex.Length - 2; i += 2)
            {
                

                s.Append(Convert.ToString(Convert.ToChar(Int32.Parse(Hex.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));

            }

            return s.ToString();

        }
      
        public string GetKeyPC1(string Key)
        {
            int counter = 0;
            string[] NewK = new string[64];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    int num = int.Parse(DesTables.PC1[i, j].ToString());
                    string o = "";
                    o += Key[num - 1];
                    NewK[counter] = o;
                    counter++;
                }
            }
            Key = "";
            for (int i = 0; i < 64; i++)
            {
                Key += NewK[i];
            }
            return Key;
        }
        public string GetRo(string str, string k, string L)
        {
            int row, column, counter = 0;
            string o;
            string f = "";
            string result = "";
            string[] E_Text = new string[64];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int num = int.Parse(DesTables.E_BitSelect[i, j].ToString());
                    o = "";
                    o += str[num - 1];
                    E_Text[counter] = o;
                    counter++;
                }
            }
            str = "";
            for (int i = 0; i < 64; i++)
            {
                str += E_Text[i];
            }

            for (int i = 0; i < str.Length; i++)
            {
                f += (int)str[i] ^ (int)k[i];
            }
//======================================================================
            str = "";
            counter = 0;
            o = "";
            o += f[0].ToString() + f[5].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[1].ToString() + f[2].ToString() + f[3].ToString() + f[4].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S1[row, column].ToString()));

            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
   //=====================================================================        

            str = "";
            counter = 0;
            o = "";
            o += f[6].ToString() + f[11].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[7].ToString() + f[8].ToString() + f[9].ToString() + f[10].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S2[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
   //==============================================

            str = "";
            count = 0;
            o = "";
            o += f[12].ToString() + f[17].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[13].ToString() + f[14].ToString() + f[15].ToString() + f[16].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S3[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
  //============================================================
            str = "";
            counter = 0;
            o = "";
            o += f[18].ToString() + f[23].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[19].ToString() + f[20].ToString() + f[21].ToString() + f[22].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S4[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
 //================================================================
            str = "";
            counter = 0;
            o = "";
            o += f[24].ToString() + f[29].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[25].ToString() + f[26].ToString() + f[27].ToString() + f[28].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S5[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
//================================================================
            str = "";
            counter = 0;
            o = "";
            o += f[30].ToString() + f[35].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[31].ToString() + f[32].ToString() + f[33].ToString() + f[34].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S6[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
//==============================================================
            str = "";
            counter = 0;
            o = "";
            o += f[36].ToString() + f[41].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[37].ToString() + f[38].ToString() + f[39].ToString() + f[40].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S7[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
 //===================================================================
            str = "";
            counter = 0;
            o = "";
            o += f[42].ToString() + f[47].ToString();
            row = int.Parse(Convert.ToInt32(o, 2).ToString());
            o = "";
            o += f[43].ToString() + f[44].ToString() + f[45].ToString() + f[46].ToString();
            column = int.Parse(Convert.ToInt32(o, 2).ToString());
            str = ToBinary(int.Parse(DesTables.S8[row, column].ToString()));


            while (str.Length < 4)
            {
                str = "0" + str;
            }


            result += str;
//=========================================================
            result = GetPermutation(result);
            string R = "";
            for (int i = 0; i < result.Length; i++)
            {
                R += Add_Binary(L[i].ToString(), result[i].ToString());
            }



            return Ro;
        }
        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);



            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {

                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        public string[] DividBinaryStr(string str)
        {
            string[] DividedText = new string[2];
            for (int i = 0; i < str.Length / 2; i++)
            {
                DividedText[0] += str[i].ToString();
            }
            for (int i = str.Length / 2; i < str.Length; i++)
            {
                DividedText[1] += str[i].ToString();
            }
            return DividedText;
        }
        public string CombineText(string str1, string str2)
        {
            string Text = "";
            Text += str1 + str2;
            return Text;
        }
        public string Shift_Left(string str, int ShiftNum)
        {
            if (ShiftNum == 1)
            {
                str = str[1].ToString() + str[2].ToString() + str[3].ToString() + str[4].ToString() + str[5].ToString() + str[6].ToString() + str[7].ToString() + str[8].ToString() + str[9].ToString() + str[10].ToString() + str[11].ToString() + str[12].ToString() + str[13].ToString() + str[14].ToString() + str[15].ToString() + str[16].ToString() + str[17].ToString() + str[18].ToString() + str[19].ToString() + str[20].ToString() + str[21].ToString() + str[22].ToString() + str[23].ToString() + str[24].ToString() + str[25].ToString() + str[26].ToString() + str[27].ToString() + str[0].ToString();
            }
            if (ShiftNum == 2)
            {
                str = str[2].ToString() + str[3].ToString() + str[4].ToString() + str[5].ToString() + str[6].ToString() + str[7].ToString() + str[8].ToString() + str[9].ToString() + str[10].ToString() + str[11].ToString() + str[12].ToString() + str[13].ToString() + str[14].ToString() + str[15].ToString() + str[16].ToString() + str[17].ToString() + str[18].ToString() + str[19].ToString() + str[20].ToString() + str[21].ToString() + str[22].ToString() + str[23].ToString() + str[24].ToString() + str[25].ToString() + str[26].ToString() + str[27].ToString() + str[0].ToString() + str[1].ToString();
            }
            return str;
        }
        public string GetIP(string str)
        {
            int counter = 0;
            string[] IP_Text = new string[64];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int num = int.Parse(DesTables.IP[i, j].ToString());
                    string o = "";
                    o += str[num - 1];
                    IP_Text[counter] = o;
                    counter++;
                }
            }
            str = "";
            for (int i = 0; i < 64; i++)
            {
                str += IP_Text[i];
            }
            return str;
        }
        public string ConvertHexToBinary(string Hex)
        {
            string ConveredText1;
            ConveredText1 = Convert.ToString(Convert.ToInt64(Hex, 16), 2);
            if (ConveredText1.Length < Hex.Length * 4)
            {
                string ConvertedText2 = ConveredText1;
                for (int i = 0; i < (Hex.Length * 4 - ConveredText1.Length); i++)
                {
                    ConvertedText2 = "0" + ConvertedText2;
                }
                ConveredText1 = ConvertedText2;
            }
            return ConveredText1;
        }
        public string GetIP1(string str)
        {
            int counter = 0;
            string[] IP_Text = new string[64];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int num = int.Parse(DesTables.IP[i, j].ToString());
                    string o = "";
                    o += str[num - 1];
                    IP_Text[counter] = o;
                    counter++;
                }
            }
            str = "";
            for (int i = 0; i < 64; i++)
            {
                str += IP_Text[i];
            }
            return str;
        }
        public string GetPermutation(string str)
        {
            int counter = 0;
            string[] P_Text = new string[32];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int num = int.Parse(DesTables.P[i, j].ToString());
                    string o = "";
                    o += str[num - 1];
                    P_Text[counter] = o;
                    counter++;
                }
            }
            str = "";
            for (int i = 0; i < 32; i++)
            {
                str += P_Text[i];
            }
            return str;
        }
        public static string ToBinary(Int64 Decimal)
        {
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal / 2;
            }

            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);

            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }   
        public string Add_Binary(string str1, string str2)
        {
            string Text;
            if (str1 == str2)
                Text = "0";
            else
                Text = "1";
            return Text;
        }



        public int count { get; set; }

        public string Ro { get; set; }
    }
}
