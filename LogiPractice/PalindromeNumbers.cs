using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    public class PalindromeNumbers
    {
        public PalindromeNumbers()
        {
            Console.WriteLine("enter a num");
            int n, sum=0, r;
            n=Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine("palindrome");
            }
            else
                Console.WriteLine("not a palindrome");
            Console.ReadLine();


        }
        
    }
}
