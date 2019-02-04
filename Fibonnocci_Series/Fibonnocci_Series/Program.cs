using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnocci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter the number of elements");
            n = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1= n2;
                n2 = n3;
            }
            Console.ReadLine();

        }
    }
}
