using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class hill_cipher
    {
        double [] num = new double [26] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int pos = 0;
        public List<char> encrpthill(string plaintext, int m,int[, ]matrix)
        {
           
            
            List<char> cipher= new List<char>();
            while(pos < plaintext.Length)
           {
               double sum = 0;
               List<double> rescipher = new List<double>();
               string sub=" ";
                sub = plaintext.Substring(pos, m);
                pos += m;
                char[] arr = new char[sub.Length];
                arr = sub.ToCharArray();
                double[] result = new double[sub.Length];
                
                 for (int i = 0; i < 25; i++)
                 {
                     for (int j = 0; j < arr.Length; j++)
                     {
                         if (arr[j] == alphabet[i])
                         {
                             result[j] = num[i];
                         }
                     }
                 }
                 for (int k = 0; k < m; k++)
                 {
                     sum = 0;
                     for (int h = 0; h < m; h++)
                     {
                         sum += matrix[k, h] * result[h];
                         sum = sum % 26;
                     }

                     rescipher.Add(sum);
                 }
                 char[] res = new char[rescipher.Count];
                 for (int i = 0; i < 25; i++)
                 {
                     for (int j = 0; j < rescipher.Count; j++)
                     {
                         if (rescipher[j] == num[i])
                         {
                             res[j] = alphabet[i];
                         }
                     }
                 }
                 for (int g = 0; g < res.Length; g++)
                 {
                     cipher.Add(res[g]);
                 }

                
          }
            
            return cipher;
        }
        public int[ , ] keymatrix(int m,List<int> mvalues)
        {
          
            int[,] matrix = new int[m, m];
            
            int c = 0;
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    matrix[j, k] = mvalues[k + c];
                }
                c += m;
            }
            return matrix;

        }
        public List<char> decrpthill(string ct, int[,] matrix, int m)
        {
            int pos = 0;
            double[,] k = new double[3, 3];
            double[,] kinv = new double[3, 3];
            int det = (matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0])));
            det = det % 26;
            if (det < 0)
            {
                det = det + 26;
            }
            int diff = 26 - det;
            int a = 27;
            double c = a/ diff;
           
            while(num.Contains(c)==false)
            {
                c = (a+26) / diff;
               
                
            }
           double b = 26 - c;
           
           k[0, 0] =((( b * (Math.Pow(-1,0)) * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) %26))%26;
           k[0, 1] = (((b * Math.Pow(-1,1)* ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) %26)) %26 ;
           k[0, 2] = (((b * (Math.Pow(-1, 2)) * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0])))%26)) %26;
           k[1, 0] = (((b * (Math.Pow(-1, 1)) * ((matrix[0, 1] * matrix[2, 2]) - (matrix[0, 2] * matrix[2, 1])))%26)) %26;
           k[1, 1] =(((b * (Math.Pow(-1, 2)) * ((matrix[0, 0] * matrix[2, 2]) - (matrix[0, 2] * matrix[2, 0])))%26)) %26;
           k[1, 2] = (((b * (Math.Pow(-1, 3)) * ((matrix[0, 0] * matrix[2, 1]) - (matrix[0, 1] * matrix[2, 0])))%26)) %26;
           k[2, 0] = (((b * (Math.Pow(-1, 2)) * ((matrix[0, 1] * matrix[1, 2]) - (matrix[0, 2] * matrix[1, 1])))%26)) %26;
           k[2, 1] = (((b * (Math.Pow(-1, 3)) * ((matrix[0, 0] * matrix[1, 2]) - (matrix[0, 2] * matrix[1, 0])))%26)) %26;
           k[2, 2] = (((b * (Math.Pow(-1, 4)) * ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]))) % 26)) % 26;
           if (k[0, 0] < 0)
           {
               k[0, 0] = k[0, 0] + 26;
           } 
            if (k[0, 1] < 0)
           {
               k[0, 1] = k[0, 1] + 26;
           }
           if (k[0, 2] < 0)
           {
               k[0, 2] = k[0, 2] + 26;
           }
           if (k[1, 0] < 0)
           {
               k[1, 0] = k[1, 0] + 26;
           }
           if (k[1, 1] < 0)
           {
               k[1, 1] = k[1, 1] + 26;
           }
           if (k[1, 2] < 0)
           {
               k[1, 2] = k[1, 2] + 26;
           }
           if (k[2, 0] < 0)
           {
               k[2, 0] = k[2, 0] + 26;
           }
           if (k[2, 1] < 0)
           {
               k[2, 1] = k[2, 1] + 26;
           }
           if (k[2, 2] < 0)
           {
               k[2, 2] = k[2, 2] + 26;
           }
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   kinv[i, j] = k[j, i];
               }
           }
           List<char> cipher1 = new List<char>();
           while (pos < ct.Length)
           {
               double sum = 0;
               List<double> rescipher2 = new List<double>();
               string sub = " ";
               sub = ct.Substring(pos, m);
               pos += m;
               char[] arr = new char[sub.Length];
               arr = sub.ToCharArray();
               double[] result = new double[sub.Length];

               for (int i = 0; i < 25; i++)
               {
                   for (int j = 0; j < arr.Length; j++)
                   {
                       if (arr[j] == alphabet[i])
                       {
                           result[j] = num[i];
                       }
                   }
               }
               for (int ki = 0; ki < m; ki++)
               {
                   sum = 0;
                   for (int h = 0; h < m; h++)
                   {
                       sum += kinv[ki, h] * result[h];
                       sum = sum % 26;
                   }

                   rescipher2.Add(sum);
               }
               char[] res = new char[rescipher2.Count];
               for (int i = 0; i < 25; i++)
               {
                   for (int j = 0; j < rescipher2.Count; j++)
                   {
                       if (rescipher2[j] == num[i])
                       {
                           res[j] = alphabet[i];
                       }
                   }
               }
               for (int g = 0; g < res.Length; g++)
               {
                   cipher1.Add(res[g]);
               }
           }
            return cipher1;
        }
    }


}



