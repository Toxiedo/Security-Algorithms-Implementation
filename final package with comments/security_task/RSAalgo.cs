using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    class RSAalgo
    {
        public double encrypt(int p, int q, int e, int m)
        {
            double mul = 1; double c = 0;
            int d;
            int n = p * q;
            int q_n = (p - 1) * (q - 1);
            mul_inverse mul_inv = new mul_inverse();
            d = mul_inv.mulinverse(e, q_n);
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
                    mul = (mul * m) % n;
                }
            }
            return mul;
        }
        public double decrypt(int p, int q, int e, int cipher)
        {
            double mul = 1; double c = 0;
            int d;
            int n = p * q;
            int q_n = (p - 1) * (q - 1);
            mul_inverse mul_inv = new mul_inverse();
            d = mul_inv.mulinverse(e, q_n);
            string y = d.ToString();
            y = Convert.ToString(Convert.ToInt32(y, 10), 2);
            int K = y.Count();
            for (int i = 0; i < K; i++)
            {
                c *= 2;
                mul = (mul * mul) % n;
                if (y[i] == '1')
                {
                    c = c + 1;
                    mul = (mul * cipher) % n;
                }
            }
            return mul;
        }
    }
}
