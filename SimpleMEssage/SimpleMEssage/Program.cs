using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMEssage
{
    class Program
    {
        delegate void Iterator();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
            int val1 = 0 ; //must be defined 
            int val2; //optional

            Keywords1(ref val1);
            Console.WriteLine(val1); // val1=7
            Console.ReadLine();

            Keywords2(out val2);
            Console.WriteLine(val2); // val2=9
            Console.ReadLine();

            int[] x = { 10, 20, 30, 50 ,7};
            int temp = 0;
            for (int i = 0; i < x.Count(); i++)
            {
                if(x[i] % 2 == 0)
                    temp = x[i] + temp;
            }
            Console.WriteLine("The added value is  = "+temp);
            Console.ReadLine();

            long sum = TotalAllEvenInts(x);
            Console.WriteLine("The added value is  = " + sum);
            Console.ReadLine();

            

        }
        static long TotalAllEvenInts(int[] intArray)
        {
            return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }
        static void Keywords1(ref int value) //called method
        {
            value = 7;
        }
        static void Keywords2(out int value) //called method
        {
            value = 9; //must be defined 
        }
    }
}
