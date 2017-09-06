using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {

        //insertion sort masih rusak
        static void Main(string[] args)
        {
            int[] inputUnsortedArray = { 8, 7, 6, 8, 9, 10, 1, 2, 3 };

            insertionSort(inputUnsortedArray);
        }
        static void insertionSort(int[] input)
        {

            int cek;
            for (var i = 1; i < input.Length; i++)
            {
                cek = input[i];
                int j = i - 1;
                
                while (input[j]>cek && j > 0)//harusnya while (input[j]>cek && j >= 0) tapi rusak di input[-1]
                {
                    input[j + 1] = input[j];
                    j--;
                    
                }
                j++;
                input[j] = cek;

            }


        }
    }
}
