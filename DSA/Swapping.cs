using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class Swapping
    {
        
        public Swapping()
        {
           int a=2, b=4;
            Console.WriteLine("before swapping " + a + " and"+ b);
            a = a + b;//6
            b = a - b;//2
            a = a - b;//4
            Console.WriteLine("before swapping " + a + " and" + b);
            Console.ReadLine();

        }



    }
}
