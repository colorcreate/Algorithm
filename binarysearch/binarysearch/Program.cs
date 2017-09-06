using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 0;
            
            Console.WriteLine(target+" berada di index ke-"+binarysearch(arr, target));
            Console.ReadLine();
        }
        static int binarysearch(int[] input, int target)
        {
            int min = 0;
            int max = input.Length - 1;
            int result = -1;
            bool p = true;
            
            
            while (p==true)
            {
                int index = (max - min) / 2;
                if (input[min+index] == target)
                {
                    result = min+index;
                    p = false;
                }
                else if (input[index] < target)
                    min = min+index + 1;
                else
                    max = index - 1;
            }
            return result;
        }
    }
}
