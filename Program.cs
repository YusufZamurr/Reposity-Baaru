using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deret_bilangan_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = new int[0];
            int bilangan;
            Console.WriteLine("Deret Fibonacci");
            bilangan = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <bilangan; i++)
            {
                Array.Resize(ref fibo, fibo.Length + 1);
                if (i == 0 || i == 1)
                {
                    fibo[i] = 1;
                    Console.Write(fibo[i] + " ");

                }
                else
                    fibo[i] = fibo[i - 2] + fibo[i - 1];
                    Console.Write(fibo[i] + " ");
            }
        }
            Console.ReadKey();
    }
}
