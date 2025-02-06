using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class EvenOdd
    {
        public EvenOdd()
        {
            int[] num = { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10, };
            List<int> even = new List<int>();
            List<int> odd = new List<int>();


            int len = num.Length - 1;
            for (int i = 0; i <= len; i++)
            {

                if (num[i] % 2 == 0)
                {
                     even.Add(num[i]);


                }
                else
                {
                    odd.Add(num[i]);
                }
            }
            Console.WriteLine("Even numbers: " + string.Join(", ", even));
            Console.WriteLine("Odd numbers: " + string.Join(", ", odd));


        }
    }
}
