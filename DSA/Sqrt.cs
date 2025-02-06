using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    public class Sqrt
    {
        public int Sqrts()
        {
        //     int n = 390;
        //double res=(double )Math.Sqrt(n);
        //    Console.WriteLine(  res);


            int n =45;
            int res = 1;
            while (res * res <= n)
            {
                res++;
            }
            return res - 1;
        }
      
    }
}
