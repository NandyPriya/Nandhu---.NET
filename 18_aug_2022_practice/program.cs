using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box_and_unbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float t = 9.87f;
            double g = t;//assign float to double
            Console.WriteLine("float to double ="+g);//boxing
            float t1 = (float)g;
            Console.WriteLine("double to float ="+t1);//unboxing
            int k = 90;
            string r = k.ToString();//assign int to string
            Console.WriteLine("int to string ="+r);//boxing
            int k1 = Convert.ToInt32(r);
            Console.WriteLine("string to int ="+k1);//unboxing
            string y = "hello";//assign string to object
            object obj1 = y;//boxing
            Console.WriteLine(" string to object ="+obj1);
            y = (string)obj1;//unboxing
            Console.WriteLine("object to string ="+y);
            Console.WriteLine("================================================================");
            int j = 90;
            object o = "90";
            
            bool res = o.Equals(j);
            Console.WriteLine(res);
            Console.Read();



        }
    }
}
