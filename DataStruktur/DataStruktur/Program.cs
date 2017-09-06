using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruktur
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Quetion1 reverse
            //string input = "Ab,c,de!$";
            //char[] inp = input.ToCharArray();
            //Console.Write(input + " =====> ");
            //reverse(inp);

            ////Quetion2 Count triplets with sum smaller than a given value
            //int[] input = { 5, 1, 3, 4, 7 };
            //int sum = 12;
            //Console.WriteLine(countTriplets(input, sum));

            ////Quetion4 pythagorean triplet in an array
            ////untuk saat ini jika salah, outputnya berupa tripel 0, jika benar selain itu
            //int[] input = { 10, 4, 6, 12, 5 };
            //pythagorean(input);

            ////Quetion5 Length of the largest subarray with continuous elements
            //int[] input = { 1, 2, 3, 4, 5, 6, 7, 56, 58, 57, 90, 92, 94, 93, 91, 45 };
            //longest(input);

            ////Quetion6 Find the smallest positive integer value that cannot be represented as sum of any subset of a given array
            //int[] input= { 1, 3, 6, 10, 11, 15 };
            //smallest(input);

            //Alvin request
            int[] input = { 5, 1, 4, 6, 9, 12, 15 };
            TheBesto(input);
        }

        //Alvin request
        static void TheBesto(int[] input)
        {
            int a = 0; int b = 1; int c = 2;
            bool p = false;
            while (p==false)
            {
                p = cektripel(input[a], input[b], input[c]);
                c++;
                if (c==input.Length)
                {
                    b++;
                    c = b + 1;
                }
                if (b==input.Length-1)
                {
                    a++;
                    b = a + 1;
                    c = b + 1;
                }
                if (a == input.Length - 2)
                    break;
            }
            Console.WriteLine(p);
        }

        //Quetion1 (udah)
        static void reverse(char[] inp)
        {
            List<int> index = new List<int>();
            List<char> letter = new List<char>();

            for (var i = 0; i < inp.Length; i++)
            {
                if (Char.IsLetter(inp[i]))
                {
                    letter.Add(inp[i]);
                    index.Add(i);
                }

            }
            letter.Reverse();

            for (int i = 0; i < letter.Count(); i++)
                inp[index[i]] = letter[i];

           
            foreach (var x in inp)
                Console.Write(x);

            string output =
            Console.ReadLine();
        }

        //Quetion2 (udah)
        static int countTriplets(int[] input, int sum)
        {
            int count = 0;
            for (int i = 0; i < input.Length - 2; i++)
                for (int j = i + 1; j < input.Length - 1; j++)
                    for (int k = j + 1; k < input.Length; k++)
                        if (input[i] + input[j] + input[k] < sum)
                            count++;
            return count;
        }

        //Quetion4 (udah)
        static void pythagorean(int[] input)
        {
            bool p = true;
            int i = 0;
            //int a = 0; int b = 0; int c=0;
            while (p==true && i<input.Length-2)
            {
                int j = i + 1;
                while (p==true && j<input.Length-1)
                {
                    int k = j + 1;
                    while (p==true && k<input.Length)
                    {
                        bool q = cektripel(input[i], input[j], input[k]);
                        if (q==true)
                        {
                            p = false;
                            //a = input[i]; b = input[j]; c = input[k];
                            
                        }
                        k++;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine("Output: " + !p);
        }

        //fungsi pembantu Quetion4 (udah)
        static bool cektripel(int a, int b, int c)
        {
            if (a * a + b * b == c * c) return true;
            else if (a * a + c * c == b * b) return true;
            else if (b * b + c * c == a  *a) return true;
            else return false;
        }

        //Quetion5  (udah)
        static void longest(int[] input)
        {
            Array.Sort(input);
            int result = 1;
            int cek = 1;

            for (var i=0; i<input.Length-1; i++)
            {
                if (input[i]+1 == input[i + 1])
                {
                    cek++;
                }
                else
                {
                    cek = 1;
                }
                if (result < cek)
                {
                    result = cek;
                }
            }

            Console.WriteLine("Output: Length of the longest contiguous subarray is "+result);
        }

        //Quetion6
        static void smallest(int[] input)
        {
            int res = 1;

            for (int i = 0; i < input.Length && input[i] <= res; i++)
                res = res + input[i];

            Console.WriteLine(res);
        }


    }
}
