using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace AchaoCalculate
{
    class PrintCalcuate
    {
       
        public PrintCalcuate(int n)
        {
            
            int i = 0;
            int a, b, c, d, e, f;
            string st;
            Random rd = new Random();
            while (i < n)
            { 
                a = rd.Next(0, 100);
                b = rd.Next(0, 100);
                c = rd.Next(0, 100);
                d = rd.Next(0, 100);
                e = rd.Next(0, 100);
                f = rd.Next(1, 100);
                int m =rd.Next(0,9);
                switch (m)
                {
                    
                    case 0:
                        int end1 = b * c - a;
                        st = b + "*" + c + "-" + a + "=" + end1;
                        if (end1 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 1:
                        int end2 = e - c + b;
                        st = e + "-" + c + "+" + b + "=" + end2;
                        if (end2 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 2:
                        int end3 = e + f * d + c;
                        st = e + "-" + f + "*" + d + "+" + c + "=" + end3;
                        if (end3 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 3:
                        int end4 = b / f + e;
                        st = b + "/" + f + "+" + e + "=" + end4;
                        if (b % f == 0 && end4 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 4:
                        int end5 = c / f + c * d;
                        st = c + "/" + f + "+" + c + "*" + d + "=" + end5;
                        if (c % f == 0 && end5 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 5:
                        int end6 = e - c / f;
                        st = e + "-" + c + "/" + f + "=" + end6;
                        if (c % f == 0 && end6 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 6:
                        int end7 = e * f - c;
                        st = e + "*" + f + "-" + c + "=" + end7;
                        if (end7 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 7:
                        int end8 = e * f - c + a;
                        st = e + "*" + f + "-" + c + "+" + a + "=" + end8;
                        if (end8 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 8:
                        int end9 = e + c / f - a;
                        st = e + "+" + c + "/" + f + "-" + a + "=" + end9;
                        if (c % f == 0 && end9 >= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;
                    case 9:
                        int end10 = c - a / f + a;
                        st = c + "-" + a + "/" + f + "+" + a + "=" + end10;
                        if (a % f == 0 && end10>= 0)
                        {
                            Console.WriteLine(st);
                            CreatFile sw = new CreatFile(st);
                            i++;
                        }
                        break;

                    default:
                        break;


                        
                }
                
                
            }



        }


    }

}