using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class AES_Decryption
    {
        public static string LeftShift2(string text, int level)
        {
            //string temp = text.Substring(0, count);
            StringBuilder shifted = new StringBuilder(text.Length);
            shifted.Append(text.Substring(1) + "0");

            if (!level.Equals(8))
            {
                for (int i = 0; i <= text.Length - (1 + level); i++)
                {
                    shifted[i] = '0';
                }
            }

            return shifted.ToString();
        }
    
    }
}
