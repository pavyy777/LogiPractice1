using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class SumOfNumbers
    {
        public SumOfNumbers() {
            int n = 10;
            int result = 0;
            for (int i = 1; i < n; i++)
            {
                 result = result + i;
            }
            Console.WriteLine(  result);
            Console.ReadLine();
        }
    }
}
