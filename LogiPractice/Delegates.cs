using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogiPractice.Delegates;

namespace LogiPractice
{
    public class Delegates
    {
        public delegate void addnum(int a,int b);
        public void sum(int a, int b)
        {

            Console.WriteLine("sum of 100 + 50 is {0}",a+b);
            Console.ReadLine();
        }
    }
    public class  new1
    {
        public new1()
        {
            Delegates del = new Delegates();
            addnum a = new addnum(del.sum);
            a(100, 50);
        }

    }
    
}
