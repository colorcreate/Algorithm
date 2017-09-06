using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //ini seharusnya bubble sort(mencari posisi input[i])
        //tapi malah mencari isi input[i]
        static void Main(string[] args)
        {
            int[] inputUnsortedArray = { 8, 7, 6, 8, 9, 10, 1, 2, 3 };
            
            bubbleSort(inputUnsortedArray);
        }
        static void bubbleSort(int[] input)
        {
            
            int cek;
            for (var i = 0; i < input.Length; i++)
            {                
                for (var j=i+1; j<input.Length; j++)
                {
                    if (input[i]<input[j])
                    {
                        cek = input[i];
                        input[i] = input[j];
                        input[j] = cek;
                    }
                }
            }

            
        }
    }
}
