using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    
    class hellman
    {
        public double key_a;
        public double key_b;
        double ya, yb;
        public void exchange_key(double q, double alpha, double xa, double xb)
        {
             ya = Calculate_power(xa, alpha, q);
             yb = Calculate_power(xb, alpha, q);
             key_a = Calculate_power(xa, yb, q);
             key_b = Calculate_power(xb, ya, q);


        }
        private double Calculate_power(double e, double m, double n)
        {
            double mul= 1; double c = 0;
            string y = e.ToString();
            y = Convert.ToString(Convert.ToInt32(y, 10), 2);
            int K = y.Count();
            for (int i = 0; i < K; i++)
            {
                c *= 2;
                mul = (mul * mul) % n;
                if (y[i] == '1')
                {
                    c = c + 1;
                    mul= (mul * m) % n;
                }

            }

            return mul;
        }

        
} 
     }

    

