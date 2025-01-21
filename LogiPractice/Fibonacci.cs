using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class Fibonacci
    {
        public Fibonacci()
        {
            //1,2,3,5,8,12,20
            Console.WriteLine("enter a num");
            int n, n1=0, n2=1, n3;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1+" ",n2+" ");
            for(int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
