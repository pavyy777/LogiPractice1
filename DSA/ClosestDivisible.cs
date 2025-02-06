using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class ClosestDivisible
    {
        public  ClosestDivisible()
        {
            int n = -31, m = 4;
            int lower = (n / m) * m;
            int higher;
            if ((n > 0 && m > 0) || (n < 0 && m < 0))
            {
                higher = lower + m;

            }
            else
            {
                higher = lower - m;
            }
            if(Math.Abs(n-lower)<Math.Abs(higher-n))
            {
                Console.WriteLine(lower); 
            }
            else
            {
                Console.WriteLine( higher ); 
            }
            Console.ReadLine();

        }
    }
}
