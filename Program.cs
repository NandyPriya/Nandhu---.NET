1)using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonlab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Input the First Number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number");
            j = Convert.ToInt32(Console.ReadLine());
            Callbyvalue(i, j);
            Console.WriteLine("actual value of first number :" + i);
            Console.WriteLine("actual value of second number:" + j);
            callbyreference(ref i, ref j);
            Console.WriteLine("actual value of first number :" + i);
            Console.WriteLine("actual value of second number:" + j);
            Console.ReadLine();
        }

         static void callbyreference(ref int i, ref int j)
        {

            int k = i;
            i = j;
            j = k;
            Console.WriteLine("after swapping  first number using reference:" + i);
            Console.WriteLine("after swapping second number using reference:" + j);
        }

        static  void Callbyvalue(int i,int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("after swapping first number using value:"+i);
            Console.WriteLine("after swapping of second number using value:" + j);
        }
        
    }
}
==========================================================================================================================================================
2) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonday3_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,h;
            Console.WriteLine("enter the first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            k = Convert.ToInt32(Console.ReadLine());
            h = i * j * k;
            Console.WriteLine("{0}*{1}*{2} = {3}",i,j,k,h);
            Console.ReadLine();


        }
    }
}
========================================================================================================================================================
3) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hansonday3_3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Input the first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            j = Convert.ToInt32(Console.ReadLine());
            int h = i + j;
            int l = i - j;
            int m = i * j;
            int n = i / j;

            Console.WriteLine("{0}+{1} ={2} ", i, j, h);
            Console.WriteLine("{0}-{1} = {2}", i, j,l);
            Console.WriteLine("{0}*{1} = {2}", i, j, m);
            Console.WriteLine("{0}/{1} = {2}", i, j, n);
            Console.ReadLine();

        }
    }
}
===============================================================================================================================================
4) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonday3_4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n,h;
            Console.WriteLine("enter the first number");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the fourth number");
            n = Convert.ToInt32(Console.ReadLine());
             h = (i + j + m + n);
            Console.WriteLine("Average is"+ h+"/4");
            Console.ReadLine();


        }
    }
}
======================================================================================================================================
    5) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonday3_5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z,l,m;
            Console.WriteLine("enter the first number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            z = Convert.ToInt32(Console.ReadLine());
            l = (x + y) * z;
            m = (x * y)+(y*z);
             
            Console.WriteLine("Results of specified numbers {0},{1} and {2},(x+y).z is {3} and x.y+y.z is {4}",x,y,z,l,m);
            Console.ReadLine();
        }
    }
}
===================================================================================================================================================
    6) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
            Console.ReadLine();
        }
    }
}
=========================================================================================================================================================
    7) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("Enter a digit");
            digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", digit, digit, digit, digit);
            Console.WriteLine("{0}{0}{0}{0}", digit, digit, digit, digit);
            Console.WriteLine("{0} {0} {0} {0}", digit, digit, digit, digit);
            Console.WriteLine("{0}{0}{0}{0}", digit, digit, digit, digit);
            Console.ReadLine();
        }
    }
}
=========================================================================================================================================================
    8) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            float f,l;
            Console.WriteLine("Enter the amount of celsius");
            d = Convert.ToInt32(Console.ReadLine());
            f = ((d * 9) / 5) + 32;
            l = d + 273;
            Console.WriteLine("Fahrenheit = "+f);
            Console.WriteLine("Kelvin = " + l);
            Console.ReadLine();
        }
    }
}
===========================================================================================================================================================
    9) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Enter a number");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}",d,d,d);
            Console.WriteLine("{0} {0}", d, d);
            Console.WriteLine("{0} {0}", d, d);
            Console.WriteLine("{0} {0}", d, d);
            Console.WriteLine("{0}{0}{0}", d, d, d);
            Console.ReadLine();
        }
    }
}
=============================================================================================================================================================
    10) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, m;
            Console.WriteLine("Input first integer");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer");
            m = Convert.ToInt32(Console.ReadLine());
            if ((l < 0 && m> 0)||(l>0 && m<0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
===============================================================================================================================================================
    11) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_11th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "";
            string s3 = null;
             bool ans = String.IsNullOrEmpty(s2);
            bool ans1 = String.IsNullOrEmpty(s3);
            bool ans2 = String.IsNullOrEmpty(s3);
            Console.WriteLine("{0} = {1} ",s1,ans2);
            Console.WriteLine("{0} = {1}",s2,ans);
            Console.WriteLine("{0} =  {1}",s3,ans1);
            Console.ReadLine();





        }
        
            
        

    }
}
====================================================================================================================================================
    12) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_12th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m,km,m1,km1;
            Console.WriteLine("Enter the meter");
            m = Convert.ToInt32(Console.ReadLine());
            km = m / 1000;
            Console.WriteLine("Convert meter to kilometer is "+km);
            Console.WriteLine("Enter the kiolmeter");
            km1 = Convert.ToInt32(Console.ReadLine());
            m1 = km1 * 1000;
            Console.WriteLine("Convert kilometer to meter is " + m1);
            Console.ReadLine();
        }
    }
}
==============================================================================================================================================
    13) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_13th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            float g;
            Console.WriteLine("Enter the amount of celsius");
            d = Convert.ToInt32(Console.ReadLine());
            g = ((d * 9) / 5) + 32;
            Console.WriteLine("convert celsius to fahrenheit is "+ g);
            Console.ReadLine();
        }
    }
}
=============================================================================================================================================
    14) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_14th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float d, j;
            Console.WriteLine("Enter the US Dollar");
            d = Convert.ToInt32(Console.ReadLine());
            j = d * 70;
            Console.WriteLine("Convert US Dollar to Indian Rupees is " + j);
            Console.ReadLine();
        }
    }
}
===================================================================================================================================================
    15) using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdday_15th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b, v;
            Console.WriteLine("Enter the first integer");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second ineteger");
            v = Convert.ToInt32(Console.ReadLine());
            if((b>0 && v>0))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
            
        }
    }
}

