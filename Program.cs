using System;
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
