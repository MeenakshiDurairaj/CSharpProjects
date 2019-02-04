using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, flag = 0;
            Console.WriteLine("Enter the Number to check:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if(n % 2 == 0)
                {
                    Console.WriteLine("Number is not prime number");

                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
            Console.ReadLine();

        }
    }
}
