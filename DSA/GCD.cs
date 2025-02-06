using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class GCD
    {
        //Greatest common devisors

        public int GCD1(int a, int b)
        {
            while (b != 0)  // Continue until remainder is 0
            {
                int temp = b;  // Store b in temp
                b = a % b;     // Compute remainder
                a = temp;      // Assign b to a
            }
            return a;  // Return GCD

        }
       

            public void LCM(int a, int b)
            {
            int rslt=(a*b)/GCD1(a,b);
            Console.WriteLine(  rslt);

        }
    }
}