using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class mul_inverse
    {
        List<int> Q = new List<int>();
        List<int> A1 = new List<int>();
        List<int> A2 = new List<int>();
        List<int> A3 = new List<int>();
        List<int> B1 = new List<int>();
        List<int> B2 = new List<int>();
        List<int> B3 = new List<int>();
        int i = 0;
        int mulinv = 0;
        public int mulinverse(int m,int n)
        {

            Q.Add(0);/////first step///q=0
            A1.Add(1);
            A2.Add(0);
            A3.Add(n);///////modules/////
            B1.Add(0);
            B2.Add(1);
            B3.Add(m);//////  base//////
            while(B3[i] != 0 || B3[i] != 1)
            {
                if ((B3[i] == 0) || B3[i] == 1)//////stop condition///////
                {
                    break;
                }
                i++;
                int q = A3[i - 1] / B3[i - 1];
                Q.Add(q);
                A1.Add(B1[i - 1]);////////  basawy el A bel B///////
                A2.Add(B2[i - 1]);
                A3.Add(B3[i - 1]);
                int b1 = A1[i - 1] - (Q[i] * B1[i - 1]);/////calculate  new b/////
                int b2 = A2[i - 1] - (Q[i] * B2[i - 1]);
                int b3 = A3[i - 1] - (Q[i] * B3[i - 1]);
                B1.Add(b1);
                B2.Add(b2);
                B3.Add(b3);
            }
           
            
              if (B3[i] == 0)
            {
                 mulinv = A3[i];///////////multiplicative inverse/////////////
            }
              else
               {
                 mulinv = B2[i];
               }

              

              return mulinv;
        }
    }
}
