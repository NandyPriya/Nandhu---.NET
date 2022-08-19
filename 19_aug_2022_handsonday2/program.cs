using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            1)     int i1, j1, max, min;
            Console.WriteLine("enter a first number");
            i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            j1 = Convert.ToInt32(Console.ReadLine());
            max = ((i1 + j1 + Math.Abs(i1 - j1)) / 2);
            min = ((i1 + j1 - Math.Abs(i1 - j1)) / 2);
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("=====================================================================================================================================");

            2)      int i, j, k;
            Console.WriteLine("enter a first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a third number");
            k = Convert.ToInt32(Console.ReadLine());
            if ((i != 0 && j != 0) && k != 0)
            {
                if ((i > j) && (i > k))
                {
                    Console.WriteLine("{0}is greater number", i);
                }
                else if ((j > i) && (j > k))
                {
                    Console.WriteLine("{0}is greater number", j);
                }
                else
                {
                    Console.WriteLine("{0}is greater number", k);
                }

            }
            else
            {
                Console.WriteLine("pls enter number > 0");
            }
            Console.WriteLine("======================================================================================================================================");

            3)        char t, n;
            Console.WriteLine("enter a first character");
            t = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter a second character");
            n = Convert.ToChar(Console.ReadLine());
            bool ans = t.Equals(n);
            Console.WriteLine("compare twocharacter is" + ans);
            Console.WriteLine("======================================================================================================================================");

            4)         string o, p;
            Console.WriteLine("enter a first string");
            o = Console.ReadLine();
            Console.WriteLine("enter a second string");
            p = Console.ReadLine();

            if (o == p)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("======================================================================================================================================");

            5)        int l, f;
            Console.WriteLine("enter a first number");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            f = Convert.ToInt32(Console.ReadLine());
            if (l > f)
            {
                Console.WriteLine("biggest number is" + l);
            }
            else
            {
                Console.WriteLine("biggest number is" + f);
            }
            
            Console.WriteLine("======================================================================================================================================");

            6)       int h;
            Console.WriteLine("enter a year");
            h = Convert.ToInt32(Console.ReadLine());
            if(((h%4==0)&&(h%100!=0))|| (h % 400 == 0))
            {
                Console.WriteLine("{0} is leap year",h);
            }
            else
            {
                Console.WriteLine("{0} is not a  leap year", h);
            }

            Console.WriteLine("======================================================================================================================================");

            7)         int m, d, y;
            Console.WriteLine("enter a first subject");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second subject");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a third subject");
            y = Convert.ToInt32(Console.ReadLine());
            int g = (m + d + y);
            Console.WriteLine(g);
            double per = (float)g / 300 * 100.0;
            Console.WriteLine(per);
            if(per>=60)
            {
                Console.WriteLine("first");
            }
            else if(per>=45 && per<=60)
            {
                Console.WriteLine("second");
            }else if(per >= 35 && per <= 45)
            {
                Console.WriteLine("third");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.WriteLine("======================================================================================================================================"); 
           
            8)           for(int x=1;x<=5;x++)
            {
                for(int c=1;c<=x;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("======================================================================================================================================"); 
            9)       int e;int s1=0;
            Console.WriteLine("enter a n value");
            e = Convert.ToInt32(Console.ReadLine());
            for(int b=1;b<=e;b++)
            {
                
                
                if (b % 2 != 0)
                {
                    Console.WriteLine(b);
                    s1 = s1 + b;
                }
                
            }
            Console.WriteLine("sum of odd natural numbers is" + s1);
            Console.WriteLine("======================================================================================================================================"); 

             10)             int u,rem,rev=0;
            Console.WriteLine("enter a number");
            u = Convert.ToInt32(Console.ReadLine());
            while(u!=0)
            { rem = u % 10;
                rev = rev * 10 + rem;
                u /= 10;
            }
            Console.WriteLine("reverse number is "+rev);
            Console.WriteLine("======================================================================================================================================"); 
            11)           int sum = 0;
            for(int s=100;s<=200;s++)
            {

                    sum = sum + s;
                
            }
            Console.WriteLine("The sum of numbers between 100 and 200:" + sum);
            Console.WriteLine("======================================================================================================================================");
             12)       int sum1 = 0;
            for (int r = 100; r <= 200; r++)
            {
                if (r % 9 == 0) {
                    Console.WriteLine("Numbers between 100 and 200, divisible by 9:"+r);
                    sum1 = sum1 + r;
                }
                

            }
            Console.WriteLine("The sum:" + sum1);
            Console.WriteLine("======================================================================================================================================");
           /* int q;
            Console.WriteLine("enter a number");
            q = Convert.ToInt32(Console.ReadLine());
            if (q == 0)
            {
                Console.WriteLine("number is zero");

            }
            if (q % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            if (q % 2 != 0)
            {
                Console.WriteLine("number is odd");
            }

            if (q % 10 == 0)
            {
                Console.WriteLine("number is multiple of 10 ");

            }
            if (q > 100)
            {
                Console.WriteLine("number is too large");


            }
             Console.WriteLine("====================================================");
            int l;
            Console.WriteLine("enter a userchoice");
           
            Console.WriteLine("1.zero \n 2.odd \n 3.even \n 4.multiple of 10 \n 5.greater than 100");
            l = Convert.ToInt32(Console.ReadLine());
            switch (l)
            {
                case 1:if (l == 0)
                    {
                        Console.WriteLine("number is zero");
                    }
                    break;
                case 2:if (l%2!=0)
                    {
                        Console.WriteLine("number is zero");
                    } break;
                case 3:if (l % 2 == 0)
                    {
                        Console.WriteLine("number is zero");
                        
                    }
                    break;
                case 4:
                    if (l % 10 == 0)
                    {
                        Console.WriteLine("number is zero");

                    }
                    break;
                case 5:
                    if (l>100)
                    {
                        Console.WriteLine("number is zero");

                    }
                    break;
                default:
                    Console.WriteLine("pls enter valid number");

                    break;
            }
             Console.WriteLine("====================================================");
            for(int i=0,j=25;i+j>=i; i++,j--)
            {
               
                Console.WriteLine(i+" "+j);
                
            }
            Console.WriteLine("Crossed Over");
            Console.WriteLine("===================================================================================================================================");*/
            16)      int initial = 100,hit1=10,miss = -20;
            int remain=0;
            Console.WriteLine("enter whether hit or miss");
            for (int i=1;i<=4;i++)
            {
                string h;
               
                h = Console.ReadLine();
                if(h=="HIT")
                {
                    remain = initial + hit1;
                }
                else
                {
                    remain = initial - miss;
                }
                
            }
            Console.WriteLine("EXAMPLE OUTPUT:"+remain); */
          
            Console.ReadLine();
 Console.WriteLine("=================================================================================================================================================");
        }
    }
    }
