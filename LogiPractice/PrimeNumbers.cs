using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
     public class PrimeNumbers
     {
            public PrimeNumbers()
            {
            Console.WriteLine("enter a num");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("it is Prime");
            }
            else
                Console.WriteLine("not a prime");
            Console.ReadLine();
            }

     }
        
}
