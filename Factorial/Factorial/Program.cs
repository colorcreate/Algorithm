using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Sum(input, input.Length));
        }

        //faktorial
        static ulong Fac(ulong angka)//angka!
        {
            if (angka == 1)
                return angka;
            else
                return angka * Fac(angka - 1);
        }
        
        //fibonaci
        static int Fib(int angka)//suku ke-angka
        {
            if (angka <3)
                return 1;
            else
                return Fib(angka-1) + Fib(angka-2);
        }

        //sum array
        static int Sum(int[] input, int n)//n=input.Length
        {
            if (n==1)
            {
                return input[0];
            }
            else
            {
                return input[n - 1] + Sum(input, n - 1);
            }
            
        }

        
    }
}
