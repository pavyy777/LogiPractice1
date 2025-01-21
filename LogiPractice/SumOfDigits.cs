using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class SumOfDigits
    {
        public SumOfDigits()
        {
            Console.WriteLine("enter a num");
            int n, sum = 0, r;
            n = Convert.ToInt32(Console.ReadLine());
          
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;

            }
            Console.WriteLine(sum);Console.ReadLine();

        }
}   }

