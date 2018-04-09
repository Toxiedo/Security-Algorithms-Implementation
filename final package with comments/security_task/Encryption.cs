using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_task
{
    struct Mapst1
    {
        public char L;
        public int R;
    }
    class Encryption
    {
    
        List<List<char>>n= new List<List<char>>();
        List<Mapst1> Mappinglist = new List<Mapst1>();
        public char[] Process1(string keyword, int Type, string Output)
        {
            char[] P_text = new char[Output.Length];
            char[] KeyStream = new char[Output.Length];

           Output.ToCharArray();
            FilList();
            for (int p = 0; p < keyword.Length; p++)
            {
                KeyStream[p] = keyword[p];

            }
            switch (Type)
            {
                case 0:
                    break;
                case 1:


                    for (int i = keyword.Length; i < Output.Length; i++)
                    {

                        KeyStream[i] = Output[i - (keyword.Length)];
                    }

                    break;

                case 2:
                    for (int i = keyword.Length; i < Output.Length; i++)
                    {
                        KeyStream[i] = keyword[i - (keyword.Length)];
                    }
                    break;
            }

            for (int y = 0; y < 26; y++)
            {
                for (int x = 0; x < 26; x++)
                {
                    for (int v = 0; v < KeyStream.Length; v++)
                    {
                        if (KeyStream[v] == Mappinglist[x].L &&  Output[v] ==n[x][y] )
                        {
                            P_text[v] = Mappinglist[y].L;
                        }
                    }

                }
            }
            return P_text;
        }

     public   char[] Process(string keyword , int Type , string P_Text )
        {
            char[] Output = new char[P_Text.Length];
                char[] KeyStream= new char[P_Text.Length];
              
                P_Text.ToCharArray();
                FilList();
                for (int p = 0; p < keyword.Length;p++ )
                {
                    KeyStream[p] = keyword[p];
                    
                }
            switch (Type)
            {
                case 0 :
                    break;
                case 1:
                
                  
                    for (int i = keyword.Length ; i < P_Text.Length; i++)
                    {
                        
                      KeyStream[i] = P_Text[i-(keyword.Length)];
                    }

                    break;

                case 2:
                    for (int i = keyword.Length  ; i < P_Text.Length; i++)
                    {
                        KeyStream[i] = keyword[i-(keyword.Length)];
                    }
                    break;
        }
         
            for (int y = 0; y < 26; y++)
            {
                for (int x = 0; x < 26; x++)
                {
                    for (int v = 0; v < KeyStream.Length; v++)
                    {
                        if (KeyStream[v] == Mappinglist[x].L&& P_Text[v]==Mappinglist[y].L)

                        {
                            Output[v] = n[x][y];
                        }
                    }
                    
                }
            }
            return Output;
        }

     
        public void FilList()///////////////mapping list/////////////////
        {
            List<char> list1 = new List<char>();
            list1.Add('A');
            list1.Add('B');
            list1.Add('C');
            list1.Add('D');
            list1.Add('E');
            list1.Add('F');
            list1.Add('G');
            list1.Add('H');
            list1.Add('I');
            list1.Add('J');
            list1.Add('K');
            list1.Add('L');
            list1.Add('M');
            list1.Add('N');
            list1.Add('O');
            list1.Add('P');
            list1.Add('Q');
            list1.Add('R');
            list1.Add('S');
            list1.Add('T');
            list1.Add('U');
            list1.Add('V');
            list1.Add('W');
            list1.Add('X');
            list1.Add('Y');
            list1.Add('Z');


            List<char> list2 = new List<char>();

            list2.Add('B');
            list2.Add('C');
            list2.Add('D');
            list2.Add('E');
            list2.Add('F');
            list2.Add('G');
            list2.Add('H');
            list2.Add('I');
            list2.Add('J');
            list2.Add('K');
            list2.Add('L');
            list2.Add('M');
            list2.Add('N');
            list2.Add('O');
            list2.Add('P');
            list2.Add('Q');
            list2.Add('R');
            list2.Add('S');
            list2.Add('T');
            list2.Add('U');
            list2.Add('V');
            list2.Add('W');
            list2.Add('X');
            list2.Add('Y');
            list2.Add('Z');
            list2.Add('A');
            List<char> list3 = new List<char>();
            list3.Add('C');
            list3.Add('D');
            list3.Add('E');
            list3.Add('F');
            list3.Add('G');
            list3.Add('H');
            list3.Add('I');
            list3.Add('J');
            list3.Add('K');
            list3.Add('L');
            list3.Add('M');
            list3.Add('N');
            list3.Add('O');
            list3.Add('P');
            list3.Add('Q');
            list3.Add('R');
            list3.Add('S');
            list3.Add('T');
            list3.Add('U');
            list3.Add('V');
            list3.Add('W');
            list3.Add('X');
            list3.Add('Y');
            list3.Add('Z');
            list3.Add('A');
            list3.Add('B');
            List<char> list4 = new List<char>();

            list4.Add('D');
            list4.Add('E');
            list4.Add('F');
            list4.Add('G');
            list4.Add('H');
            list4.Add('I');
            list4.Add('J');
            list4.Add('K');
            list4.Add('L');
            list4.Add('M');
            list4.Add('N');
            list4.Add('O');
            list4.Add('P');
            list4.Add('Q');
            list4.Add('R');
            list4.Add('S');
            list4.Add('T');
            list4.Add('U');
            list4.Add('V');
            list4.Add('W');
            list4.Add('X');
            list4.Add('Y');
            list4.Add('Z');
            list4.Add('A');
            list4.Add('B');
            list4.Add('C');
            List<char> list5 = new List<char>();

            list5.Add('E');
            list5.Add('F');
            list5.Add('G');
            list5.Add('H');
            list5.Add('I');
            list5.Add('J');
            list5.Add('K');
            list5.Add('L');
            list5.Add('M');
            list5.Add('N');
            list5.Add('O');
            list5.Add('P');
            list5.Add('Q');
            list5.Add('R');
            list5.Add('S');
            list5.Add('T');
            list5.Add('U');
            list5.Add('V');
            list5.Add('W');
            list5.Add('X');
            list5.Add('Y');
            list5.Add('Z');
            list5.Add('A');
            list5.Add('B');
            list5.Add('C');
            list5.Add('D');
            List<char> list6 = new List<char>();

            list6.Add('F');
            list6.Add('G');
            list6.Add('H');
            list6.Add('I');
            list6.Add('J');
            list6.Add('K');
            list6.Add('L');
            list6.Add('M');
            list6.Add('N');
            list6.Add('O');
            list6.Add('P');
            list6.Add('Q');
            list6.Add('R');
            list6.Add('S');
            list6.Add('T');
            list6.Add('U');
            list6.Add('V');
            list6.Add('W');
            list6.Add('X');
            list6.Add('Y');
            list6.Add('Z');
            list6.Add('A');
            list6.Add('B');
            list6.Add('C');
            list6.Add('D');
            list6.Add('E');
            List<char> list7 = new List<char>();

            list7.Add('G');
            list7.Add('H');
            list7.Add('I');
            list7.Add('J');
            list7.Add('K');
            list7.Add('L');
            list7.Add('M');
            list7.Add('N');
            list7.Add('O');
            list7.Add('P');
            list7.Add('Q');
            list7.Add('R');
            list7.Add('S');
            list7.Add('T');
            list7.Add('U');
            list7.Add('V');
            list7.Add('W');
            list7.Add('X');
            list7.Add('Y');
            list7.Add('Z');
            list7.Add('A');
            list7.Add('B');
            list7.Add('C');
            list7.Add('D');
            list7.Add('E');
            list7.Add('F');
            List<char> list8 = new List<char>();

            list8.Add('H');
            list8.Add('I');
            list8.Add('J');
            list8.Add('K');
            list8.Add('L');
            list8.Add('M');
            list8.Add('N');
            list8.Add('O');
            list8.Add('P');
            list8.Add('Q');
            list8.Add('R');
            list8.Add('S');
            list8.Add('T');
            list8.Add('U');
            list8.Add('V');
            list8.Add('W');
            list8.Add('X');
            list8.Add('Y');
            list8.Add('Z');
            list8.Add('A');
            list8.Add('B');
            list8.Add('C');
            list8.Add('D');
            list8.Add('E');
            list8.Add('F');
            list8.Add('G');
            List<char> list9 = new List<char>();

            list9.Add('I');
            list9.Add('J');
            list9.Add('K');
            list9.Add('L');
            list9.Add('M');
            list9.Add('N');
            list9.Add('O');
            list9.Add('P');
            list9.Add('Q');
            list9.Add('R');
            list9.Add('S');
            list9.Add('T');
            list9.Add('U');
            list9.Add('V');
            list9.Add('W');
            list9.Add('X');
            list9.Add('Y');
            list9.Add('Z');
            list9.Add('A');
            list9.Add('B');
            list9.Add('C');
            list9.Add('D');
            list9.Add('E');
            list9.Add('F');
            list9.Add('G');
            list9.Add('H');
            List<char> list10 = new List<char>();

            list10.Add('J');
            list10.Add('K');
            list10.Add('L');
            list10.Add('M');
            list10.Add('N');
            list10.Add('O');
            list10.Add('P');
            list10.Add('Q');
            list10.Add('R');
            list10.Add('S');
            list10.Add('T');
            list10.Add('U');
            list10.Add('V');
            list10.Add('W');
            list10.Add('X');
            list10.Add('Y');
            list10.Add('Z');
            list10.Add('A');
            list10.Add('B');
            list10.Add('C');
            list10.Add('D');
            list10.Add('E');
            list10.Add('F');
            list10.Add('G');
            list10.Add('H');
            list10.Add('I');
            List<char> list11 = new List<char>();

            list11.Add('K');
            list11.Add('L');
            list11.Add('M');
            list11.Add('N');
            list11.Add('O');
            list11.Add('P');
            list11.Add('Q');
            list11.Add('R');
            list11.Add('S');
            list11.Add('T');
            list11.Add('U');
            list11.Add('V');
            list11.Add('W');
            list11.Add('X');
            list11.Add('Y');
            list11.Add('Z');
            list11.Add('A');
            list11.Add('B');
            list11.Add('C');
            list11.Add('D');
            list11.Add('E');
            list11.Add('F');
            list11.Add('G');
            list11.Add('H');
            list11.Add('I');
            list11.Add('J');
            List<char> list12 = new List<char>();

            list12.Add('L');
            list12.Add('M');
            list12.Add('N');
            list12.Add('O');
            list12.Add('P');
            list12.Add('Q');
            list12.Add('R');
            list12.Add('S');
            list12.Add('T');
            list12.Add('U');
            list12.Add('V');
            list12.Add('W');
            list12.Add('X');
            list12.Add('Y');
            list12.Add('Z');
            list12.Add('A');
            list12.Add('B');
            list12.Add('C');
            list12.Add('D');
            list12.Add('E');
            list12.Add('F');
            list12.Add('G');
            list12.Add('H');
            list12.Add('I');
            list12.Add('J');
            list12.Add('K');
            List<char> list13 = new List<char>();

            list13.Add('M');
            list13.Add('N');
            list13.Add('O');
            list13.Add('P');
            list13.Add('Q');
            list13.Add('R');
            list13.Add('S');
            list13.Add('T');
            list13.Add('U');
            list13.Add('V');
            list13.Add('W');
            list13.Add('X');
            list13.Add('Y');
            list13.Add('Z');
            list13.Add('A');
            list13.Add('B');
            list13.Add('C');
            list13.Add('D');
            list13.Add('E');
            list13.Add('F');
            list13.Add('G');
            list13.Add('H');
            list13.Add('I');
            list13.Add('J');
            list13.Add('K');
            list13.Add('L');
            List<char> list14 = new List<char>();

            list14.Add('N');
            list14.Add('O');
            list14.Add('P');
            list14.Add('Q');
            list14.Add('R');
            list14.Add('S');
            list14.Add('T');
            list14.Add('U');
            list14.Add('V');
            list14.Add('W');
            list14.Add('X');
            list14.Add('Y');
            list14.Add('Z');
            list14.Add('A');
            list14.Add('B');
            list14.Add('C');
            list14.Add('D');
            list14.Add('E');
            list14.Add('F');
            list14.Add('G');
            list14.Add('H');
            list14.Add('I');
            list14.Add('J');
            list14.Add('K');
            list14.Add('L');
            list14.Add('M');

            List<char> list15 = new List<char>();


            list15.Add('O');
            list15.Add('P');
            list15.Add('Q');
            list15.Add('R');
            list15.Add('S');
            list15.Add('T');
            list15.Add('U');
            list15.Add('V');
            list15.Add('W');
            list15.Add('X');
            list15.Add('Y');
            list15.Add('Z');
            list15.Add('A');
            list15.Add('B');
            list15.Add('C');
            list15.Add('D');
            list15.Add('E');
            list15.Add('F');
            list15.Add('G');
            list15.Add('H');
            list15.Add('I');
            list15.Add('J');
            list15.Add('K');
            list15.Add('L');
            list15.Add('M');
            list15.Add('N');
            List<char> list16 = new List<char>();


            list16.Add('P');
            list16.Add('Q');
            list16.Add('R');
            list16.Add('S');
            list16.Add('T');
            list16.Add('U');
            list16.Add('V');
            list16.Add('W');
            list16.Add('X');
            list16.Add('Y');
            list16.Add('Z');
            list16.Add('A');
            list16.Add('B');
            list16.Add('C');
            list16.Add('D');
            list16.Add('E');
            list16.Add('F');
            list16.Add('G');
            list16.Add('H');
            list16.Add('I');
            list16.Add('J');
            list16.Add('K');
            list16.Add('L');
            list16.Add('M');
            list16.Add('N');
            list16.Add('O');
            List<char> list17 = new List<char>();

            list17.Add('Q');
            list17.Add('R');
            list17.Add('S');
            list17.Add('T');
            list17.Add('U');
            list17.Add('V');
            list17.Add('W');
            list17.Add('X');
            list17.Add('Y');
            list17.Add('Z');
            list17.Add('A');
            list17.Add('B');
            list17.Add('C');
            list17.Add('D');
            list17.Add('E');
            list17.Add('F');
            list17.Add('G');
            list17.Add('H');
            list17.Add('I');
            list17.Add('J');
            list17.Add('K');
            list17.Add('L');
            list17.Add('M');
            list17.Add('N');
            list17.Add('O');
            list17.Add('P');
            List<char> list18 = new List<char>();

            list18.Add('R');
            list18.Add('S');
            list18.Add('T');
            list18.Add('U');
            list18.Add('V');
            list18.Add('W');
            list18.Add('X');
            list18.Add('Y');
            list18.Add('Z');
            list18.Add('A');
            list18.Add('B');
            list18.Add('C');
            list18.Add('D');
            list18.Add('E');
            list18.Add('F');
            list18.Add('G');
            list18.Add('H');
            list18.Add('I');
            list18.Add('J');
            list18.Add('K');
            list18.Add('L');
            list18.Add('M');
            list18.Add('N');
            list18.Add('O');
            list18.Add('P');
            list18.Add('Q');
            List<char> list19 = new List<char>();

            list19.Add('S');
            list19.Add('T');
            list19.Add('U');
            list19.Add('V');
            list19.Add('W');
            list19.Add('X');
            list19.Add('Y');
            list19.Add('Z');
            list19.Add('A');
            list19.Add('B');
            list19.Add('C');
            list19.Add('D');
            list19.Add('E');
            list19.Add('F');
            list19.Add('G');
            list19.Add('H');
            list19.Add('I');
            list19.Add('J');
            list19.Add('K');
            list19.Add('L');
            list19.Add('M');
            list19.Add('N');
            list19.Add('O');
            list19.Add('P');
            list19.Add('Q');
            list19.Add('R');
            List<char> list20 = new List<char>();

            list20.Add('T');
            list20.Add('U');
            list20.Add('V');
            list20.Add('W');
            list20.Add('X');
            list20.Add('Y');
            list20.Add('Z');
            list20.Add('A');
            list20.Add('B');
            list20.Add('C');
            list20.Add('D');
            list20.Add('E');
            list20.Add('F');
            list20.Add('G');
            list20.Add('H');
            list20.Add('I');
            list20.Add('J');
            list20.Add('K');
            list20.Add('L');
            list20.Add('M');
            list20.Add('N');
            list20.Add('O');
            list20.Add('P');
            list20.Add('Q');
            list20.Add('R');
            list20.Add('S');
            List<char> list21 = new List<char>();

            list21.Add('U');
            list21.Add('V');
            list21.Add('W');
            list21.Add('X');
            list21.Add('Y');
            list21.Add('Z');
            list21.Add('A');
            list21.Add('B');
            list21.Add('C');
            list21.Add('D');
            list21.Add('E');
            list21.Add('F');
            list21.Add('G');
            list21.Add('H');
            list21.Add('I');
            list21.Add('J');
            list21.Add('K');
            list21.Add('L');
            list21.Add('M');
            list21.Add('N');
            list21.Add('O');
            list21.Add('P');
            list21.Add('Q');
            list21.Add('R');
            list21.Add('S');
            list21.Add('T');
            List<char> list22 = new List<char>();

            list22.Add('V');
            list22.Add('W');
            list22.Add('X');
            list22.Add('Y');
            list22.Add('Z');
            list22.Add('A');
            list22.Add('B');
            list22.Add('C');
            list22.Add('D');
            list22.Add('E');
            list22.Add('F');
            list22.Add('G');
            list22.Add('H');
            list22.Add('I');
            list22.Add('J');
            list22.Add('K');
            list22.Add('L');
            list22.Add('M');
            list22.Add('N');
            list22.Add('O');
            list22.Add('P');
            list22.Add('Q');
            list22.Add('R');
            list22.Add('S');
            list22.Add('T');
            list22.Add('U');
            List<char> list23 = new List<char>();

            list23.Add('W');
            list23.Add('X');
            list23.Add('Y');
            list23.Add('Z');
            list23.Add('A');
            list23.Add('B');
            list23.Add('C');
            list23.Add('D');
            list23.Add('E');
            list23.Add('F');
            list23.Add('G');
            list23.Add('H');
            list23.Add('I');
            list23.Add('J');
            list23.Add('K');
            list23.Add('L');
            list23.Add('M');
            list23.Add('N');
            list23.Add('O');
            list23.Add('P');
            list23.Add('Q');
            list23.Add('R');
            list23.Add('S');
            list23.Add('T');
            list23.Add('U');
            list23.Add('V');
            List<char> list24 = new List<char>();

            list24.Add('X');
            list24.Add('Y');
            list24.Add('Z');
            list24.Add('A');
            list24.Add('B');
            list24.Add('C');
            list24.Add('D');
            list24.Add('E');
            list24.Add('F');
            list24.Add('G');
            list24.Add('H');
            list24.Add('I');
            list24.Add('J');
            list24.Add('K');
            list24.Add('L');
            list24.Add('M');
            list24.Add('N');
            list24.Add('O');
            list24.Add('P');
            list24.Add('Q');
            list24.Add('R');
            list24.Add('S');
            list24.Add('T');
            list24.Add('U');
            list24.Add('V');
            list24.Add('W');
            List<char> list25 = new List<char>();

            list25.Add('Y');
            list25.Add('Z');
            list25.Add('A');
            list25.Add('B');
            list25.Add('C');
            list25.Add('D');
            list25.Add('E');
            list25.Add('F');
            list25.Add('G');
            list25.Add('H');
            list25.Add('I');
            list25.Add('J');
            list25.Add('K');
            list25.Add('L');
            list25.Add('M');
            list25.Add('N');
            list25.Add('O');
            list25.Add('P');
            list25.Add('Q');
            list25.Add('R');
            list25.Add('S');
            list25.Add('T');
            list25.Add('U');
            list25.Add('V');
            list25.Add('W');
            list25.Add('X');
            List<char> list26 = new List<char>();

            list26.Add('Z');
            list26.Add('A');
            list26.Add('B');
            list26.Add('C');
            list26.Add('D');
            list26.Add('E');
            list26.Add('F');
            list26.Add('G');
            list26.Add('H');
            list26.Add('I');
            list26.Add('J');
            list26.Add('K');
            list26.Add('L');
            list26.Add('M');
            list26.Add('N');
            list26.Add('O');
            list26.Add('P');
            list26.Add('Q');
            list26.Add('R');
            list26.Add('S');
            list26.Add('T');
            list26.Add('U');
            list26.Add('V');
            list26.Add('W');
            list26.Add('X');
            list26.Add('Y');


            n.Add(list1);
            n.Add(list2);
            n.Add(list3);
            n.Add(list4);
            n.Add(list5);
            n.Add(list6);
            n.Add(list7);
            n.Add(list8);
            n.Add(list9);
            n.Add(list10);
            n.Add(list11);
            n.Add(list12);
            n.Add(list13);
            n.Add(list14);
            n.Add(list15);
            n.Add(list16);
            n.Add(list17);
            n.Add(list18);
            n.Add(list19);
            n.Add(list20);
            n.Add(list21);
            n.Add(list22);
            n.Add(list23);
            n.Add(list24);
            n.Add(list25);
            n.Add(list26);
            Mapst1 s = new Mapst1();
            s.L = 'A';
            s.R = 0;
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
    }
}
