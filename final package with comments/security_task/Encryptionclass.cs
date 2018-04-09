
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
  
    class Encryptionclass
    {
       
        
        List<Mapst> Mappinglist = new List<Mapst>();
      public  void FilList()//////////////////mapping list/////////////////
        {
            Mapst s = new Mapst();
            s.L = 'a';
            s.R = 'D';
            Mappinglist.Add(s);
            s.L = 'b';
            s.R = 'Q';
            Mappinglist.Add(s);
            s.L = 'c';
            s.R = 'E';
            Mappinglist.Add(s);
            s.L = 'd';
            s.R = 'P';
            Mappinglist.Add(s);
            s.L = 'e';
            s.R = 'R';
            Mappinglist.Add(s);
            s.L = 'f';
            s.R = 'S';
            Mappinglist.Add(s);
            s.L = 'g';
            s.R = 'F';
            Mappinglist.Add(s);
            s.L = 'h';
            s.R = 'T';
            Mappinglist.Add(s);
            s.L = 'i';
            s.R = 'A';
            Mappinglist.Add(s);
            s.L = 'j';
            s.R = 'W';
            Mappinglist.Add(s);
            s.L = 'k';
            s.R = 'X';
            Mappinglist.Add(s);
            s.L = 'l';
            s.R = 'U';
            Mappinglist.Add(s);
            s.L = 'm';
            s.R = 'G';
            Mappinglist.Add(s);
            s.L = 'n';
            s.R = 'O';
            Mappinglist.Add(s);
            s.L = 'o';
            s.R = 'B';
            Mappinglist.Add(s);
            s.L = 'p';
            s.R = 'V';
            Mappinglist.Add(s);
            s.L = 'q';
            s.R = 'H';
            Mappinglist.Add(s);
            s.L = 'r';
            s.R = 'N';
            Mappinglist.Add(s);
            s.L = 's';
            s.R = 'C';
            Mappinglist.Add(s);
            s.L = 't';
            s.R = 'M';
            Mappinglist.Add(s);
            s.L = 'u';
            s.R = 'I';
            Mappinglist.Add(s);
            s.L = 'v';
            s.R = 'Z';
            Mappinglist.Add(s);
            s.L = 'w';
            s.R = 'L';
            Mappinglist.Add(s);
            s.L = 'x';
            s.R = 'Y';
            Mappinglist.Add(s);
            s.L = 'y';
            s.R = 'J';
            Mappinglist.Add(s);
            s.L = 'z';
            s.R = 'K';
            Mappinglist.Add(s);

 
        }
         public char[] n(string st)
        {
            char[] c = st.ToCharArray();///// convert plaintext to array of char//////
             char [] res= new char[st.Length];
             for (int i = 0; i < Mappinglist.Count ; i++)
             {
                 for (int j = 0; j < st.Length ; j++)
                 {
                     if (c[j] == Mappinglist[i].L)///////matche el char with el list/////////
                     {
                         res[j] = Mappinglist[i].R;//////////nateg el encryption///////////
                     }
                 }
             }

             return res;
        }

         public char[] D(string st)
         {
             char[] c = st.ToCharArray();
             char[] res = new char[st.Length];
             for (int i = 0; i < Mappinglist.Count; i++)
             {
                 for (int j = 0; j < st.Length; j++)
                 {
                     if (c[j] == Mappinglist[i].R)
                     {
                         res[j] = Mappinglist[i].L;///////////  nateg el decryption///////////
                     }
                 }
             }

             return res;
         }

    }
}
struct Mapst
{
  public  char L;
  public  char R;
}