using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace security_task
{
    class DESalgo
    {
        BasicOperations ba = new BasicOperations();
        public string DesEncrypttion(string Key, string PlainText)
        {
            string[] DividedKey = new string[2];
            string[] C = new string[17];
            string[] D = new string[17];
            string[] k = new string[17];
            string PlainHex = ba.ConvertStringToHex(PlainText);
            PlainText = ba.ConvertHexToBinary(PlainHex);
            string[] Dividedtext = new string[2];
            string[] L = new string[17];
            string[] R = new string[17];
            string KeyHex;
            KeyHex = ba.ConvertStringToHex(Key);
            Key = ba.ConvertHexToBinary(KeyHex);
            Key = ba.GetKeyPC1(Key);
            k[0] = Key;
            DividedKey =ba.DividBinaryStr(Key);
            C[0] = DividedKey[0];
            D[0] = DividedKey[1];
         
            C[1] = ba.Shift_Left(C[0], 1);
            D[1] = ba.Shift_Left(D[0], 1);

            C[2] = ba.Shift_Left(C[1], 1);
            D[2] = ba.Shift_Left(D[1], 1);

            C[3] = ba.Shift_Left(C[2], 2);
            D[3] = ba.Shift_Left(D[2], 2);

            C[4] = ba.Shift_Left(C[3], 2);
            D[4] = ba.Shift_Left(D[3], 2);

            C[5] = ba.Shift_Left(C[4], 2);
            D[5] = ba.Shift_Left(D[4], 2);

            C[6] = ba.Shift_Left(C[5], 2);
            D[6] = ba.Shift_Left(D[5], 2);

            C[7] = ba.Shift_Left(C[6], 2);
            D[7] = ba.Shift_Left(D[6], 2);

            C[8] = ba.Shift_Left(C[7], 2);
            D[8] = ba.Shift_Left(D[7], 2);

            C[9] = ba.Shift_Left(C[8], 1);
            D[9] = ba.Shift_Left(D[8], 1);

            C[10] = ba.Shift_Left(C[9], 2);
            D[10] =ba.Shift_Left(D[9], 2);

            C[11] = ba.Shift_Left(C[10], 2);
            D[11] =ba. Shift_Left(D[10], 2);

            C[12] = ba.Shift_Left(C[11], 2);
            D[12] = ba.Shift_Left(D[11], 2);

            C[13] = ba.Shift_Left(C[12], 2);
            D[13] = ba.Shift_Left(D[12], 2);

            C[14] = ba.Shift_Left(C[13], 2);
            D[14] = ba.Shift_Left(D[13], 2);

            C[15] = ba.Shift_Left(C[14], 2);
            D[15] = ba.Shift_Left(D[14], 2);

            C[16] = ba.Shift_Left(C[15], 2);
            D[16] = ba.Shift_Left(D[15], 2);

            for (int i = 1; i < 17; i++)
            {
                k[i] = C[i] + D[i];
            }

            PlainText = ba.GetIP(PlainText);
            Dividedtext = ba.DividBinaryStr(PlainText);
            L[0] = Dividedtext[0];
            R[0] = Dividedtext[1];

            for (int i = 1; i < 17; i++)
            {
                L[i] = R[i - 1];
                R[i] = ba.GetRo(R[i - 1], k[i], L[i]);
            }
            string RL = ba.CombineText(R[16], L[16]);
            RL = ba.GetIP1(RL);
            RL = BasicOperations.BinaryStringToHexString(RL);
            return RL;
        }
        public string DesDecryption(string Key, string Text)
        {
            string Hex;
            string[] DividedKey = new string[2];
            string[] C = new string[17];
            string[] D = new string[17];
            string[] k = new string[17];
            Hex = ba.ConvertStringToHex(Key);
            Key = ba.ConvertHexToBinary(Hex);
            Key = ba.GetKeyPC1(Key);
            k[0] = Key;
            DividedKey = ba.DividBinaryStr(Key);
            C[0] = DividedKey[0];
            D[0] = DividedKey[1];

            C[1] = ba.Shift_Left(C[0], 1);
            D[1] = ba.Shift_Left(D[0], 1);

            C[1] = ba.Shift_Left(C[0], 1);
            D[1] = ba.Shift_Left(D[0], 1);

            C[2] = ba.Shift_Left(C[1], 1);
            D[2] = ba.Shift_Left(D[1], 1);

            C[3] = ba.Shift_Left(C[2], 2);
            D[3] =ba. Shift_Left(D[2], 2);

            C[4] = ba.Shift_Left(C[3], 2);
            D[4] = ba.Shift_Left(D[3], 2);

            C[5] = ba.Shift_Left(C[4], 2);
            D[5] = ba.Shift_Left(D[4], 2);

            C[6] = ba.Shift_Left(C[5], 2);
            D[6] = ba.Shift_Left(D[5], 2);

            C[7] =ba.Shift_Left(C[6], 2);
            D[7] = ba.Shift_Left(D[6], 2);

            C[8] = ba.Shift_Left(C[7], 2);
            D[8] = ba.Shift_Left(D[7], 2);

            C[9] = ba.Shift_Left(C[8], 1);
            D[9] = ba.Shift_Left(D[8], 1);

            C[10] = ba.Shift_Left(C[9], 2);
            D[10] = ba.Shift_Left(D[9], 2);

            C[11] = ba.Shift_Left(C[10], 2);
            D[11] = ba.Shift_Left(D[10], 2);

            C[12] = ba.Shift_Left(C[11], 2);
            D[12] = ba.Shift_Left(D[11], 2);

            C[13] = ba.Shift_Left(C[12], 2);
            D[13] = ba.Shift_Left(D[12], 2);

            C[14] = ba.Shift_Left(C[13], 2);
            D[14] = ba.Shift_Left(D[13], 2);

            C[15] = ba.Shift_Left(C[14], 2);
            D[15] = ba.Shift_Left(D[14], 2);

            C[16] = ba.Shift_Left(C[15], 2);
            D[16] = ba.Shift_Left(D[15], 2);

            for (int i = 1; i < 17; i++)
            {
                k[i] = C[i] + D[i];
            }

            Text =ba.ConvertHexToBinary(Text);
            Text = ba.GetIP(Text);
            string[] L = new string[17];
            string[] R = new string[17];
            string[] DividedText = new string[2];
            DividedText =ba.DividBinaryStr(Text);
            L[16] = DividedText[0];
            R[16] = DividedText[1];

            for (int i = 15; i >= 0; i--)
            {
                L[i] = R[i + 1];
                R[i] = ba.GetRo(R[i + 1], k[i], L[i]);
            }

            string RL = ba.CombineText(R[0], L[0]);
            RL = ba.GetIP1(RL);
            RL = BasicOperations.BinaryStringToHexString(RL);
           
            return RL;
        }
    }
}
