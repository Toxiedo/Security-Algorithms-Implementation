using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace security_task
{
    class Ceaser
    {
        List<Mapst1> Mappinglist = new List<Mapst1>();
        public void FilList()///////////mapping list//////////
        {
            Mapst1 s = new Mapst1();
            s.L = 'A';///////////////left side of list (chars)/////////////
            s.R = 0;///////////////right side of list (numric)/////////////
            Mappinglist.Add(s);
            s.L = 'B';
            s.R = 1;
            Mappinglist.Add(s);
            s.L = 'C';
            s.R = 2;
            Mappinglist.Add(s);
            s.L = 'D';
            s.R = 3;
            Mappinglist.Add(s);
            s.L = 'E';
            s.R = 4;
            Mappinglist.Add(s);
            s.L = 'F';
            s.R = 5;
            Mappinglist.Add(s);
            s.L = 'G';
            s.R = 6;
            Mappinglist.Add(s);
            s.L = 'H';
            s.R = 7;
            Mappinglist.Add(s);
            s.L = 'I';
            s.R = 8;
            Mappinglist.Add(s);
            s.L = 'J';
            s.R = 9;
            Mappinglist.Add(s);
            s.L = 'K';
            s.R = 10;
            Mappinglist.Add(s);
            s.L = 'L';
            s.R = 11;
            Mappinglist.Add(s);
            s.L = 'M';
            s.R = 12;
            Mappinglist.Add(s);
            s.L = 'N';
            s.R = 13;
            Mappinglist.Add(s);
            s.L = 'O';
            s.R = 14;
            Mappinglist.Add(s);
            s.L = 'P';
            s.R = 15;
            Mappinglist.Add(s);
            s.L = 'Q';
            s.R = 16;
            Mappinglist.Add(s);
            s.L = 'R';
            s.R = 17;
            Mappinglist.Add(s);
            s.L = 'S';
            s.R = 18;
            Mappinglist.Add(s);
            s.L = 'T';
            s.R = 19;
            Mappinglist.Add(s);
            s.L = 'U';
            s.R = 20;
            Mappinglist.Add(s);
            s.L = 'V';
            s.R = 21;
            Mappinglist.Add(s);
            s.L = 'W';
            s.R = 22;
            Mappinglist.Add(s);
            s.L = 'X';
            s.R = 23;
            Mappinglist.Add(s);
            s.L = 'Y';
            s.R = 24;
            Mappinglist.Add(s);
            s.L = 'Z';
            s.R = 25;
            Mappinglist.Add(s);


        }
        public char[] en(string st, int key)
        {
            int NewID;
            char[] c = st.ToCharArray();///////// convert string to array of char//////////////////
            char[] res = new char[st.Length];//////////////array feh  res of encryption/////////////////
            int[] result = new int[st.Length];//////////////array feh  ct el nateg men equation of encryption/////////////////
            for (int i = 0; i < Mappinglist.Count; i++)////////////loop 3la el mapping list///////////
            {
                for (int j = 0; j < st.Length; j++)//////////loop 3ala  plaintext//////////////
                {
                    if (c[j] == Mappinglist[i].L)//////////bshof el matching betwwen el char  w el list /////////////
                    {
                        result[j] = (Mappinglist[i].R + key) % 26;//////////bgm3 el rkam ely f index ely 7sel feh matching 3ala el key (input user) keda


                    }
                }


            }
            for (int i = 0; i < Mappinglist.Count; i++)
            {
                for (int j = 0; j < st.Length; j++)
                {
                    if (result[j] == Mappinglist[i].R)
                    {
                        res[j] = Mappinglist[i].L;//////////////array feh  res of encryption(cipher text)/////////////////


                    }
                }


            }
            return res;
        }

         public char[] DE(string st, int key)
          {

                char[] c = st.ToCharArray();
                char[] res = new char[st.Length];
                int[] result = new int[st.Length];
                for (int i = 0; i < Mappinglist.Count; i++)
                {
                for (int j = 0; j < st.Length; j++)
                {
                if (c[j] == Mappinglist[i].L)
                {
                    int sub = (Mappinglist[i].R - key);
                    if (sub < 0)
                    {
                        sub = sub + 26;
                    }
                  
                result[j] =(Math.Abs( sub) )%26;////////// nateg plaintext index/////////////


                }
                }


                }
                for (int i = 0; i < Mappinglist.Count; i++)
                {
                for (int j = 0; j < st.Length; j++)
                {
                if (result[j] == Mappinglist[i].R)
                {
                res[j] = Mappinglist[i].L;//////nateg el  decryption (plaintext)


                }
                }


                }
                return res;
                }
                }
                }
    

struct Mapst1
{
    public char L;
    public int R;
}