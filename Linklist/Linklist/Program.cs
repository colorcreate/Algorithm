using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = {"Makers", "Institute", "Bandung" };

            //LinkedList<string> ll = new LinkedList<string>(words);

            //ll.AddLast("Alvin");
            //ll.AddFirst("Kemal");
            //ll.AddAfter(ll.Find("Kemal"), "hikmat");
            //ll.AddBefore(ll.Find("Kemal"), "sandra");

            //ll.RemoveFirst();
            //ll.Remove("dan");
            //string a=ll.ElementAt(2);

            //LinkedListNode<string> node = ll.Find("Bandung");
            //ll.AddBefore(node, "Provinsi");

            //Console.WriteLine(ll.Count());
            //Console.WriteLine(ll.Contains("Bandung"));

            //int b = ll.Count();

            //string[] arrayA = new string[ll.Count];
            //ll.CopyTo(arrayA, 0);
            LinkedList<int> ll1 = new LinkedList<int>();
            ll1.AddLast(1);
            ll1.AddLast(2);
            ll1.AddLast(3);
            ll1.AddLast(5);
            ll1.AddLast(6);
            int target = 0;
            //*//substitusi(target, ll1);

            //LinkedList 1 : 7 - 5 - 9 - 4 - 6
            int[] LinkedList1 = { 7, 5, 9, 4, 6 };
            LinkedList<int> LL1 = new LinkedList<int>(LinkedList1);

            int[] LinkedList2 = { 8, 4 };
            LinkedList<int> LL2 = new LinkedList<int>(LinkedList2);


            int a = F(LL1, LL1.Count());
            int b = F(LL2, LL2.Count());

            int c = a + b;


        }
        //fungsi yang mensubstitusi suatu bilangan
        static void substitusi(int target, LinkedList<int> ll1)
        {
            int i = 0;
            if (ll1.ElementAt(i) > target)
            {
                ll1.AddBefore(ll1.First, target);
            }
            else
            {
                while (i < ll1.Count() && ll1.ElementAt(i) <= target)
                {
                    i++;
                }
                LinkedListNode<int> node = ll1.Find(ll1.ElementAt(i - 1));
                ll1.AddAfter(node, target);
            }
        
        }

        //fungsi konversi dari {2, 3, 4, 5} jadi 2345 integer
        static int F(LinkedList<int> ll, int n)
        {
            
            if (n==1)
            {
                return ll.ElementAt(n-1);
            }
            else
            {
                return F(ll, n - 1)*10+ll.ElementAt(n-1);
            }
            
        }
        
        
    }
}
