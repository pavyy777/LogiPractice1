using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class ValidTriangle
    {
        public  int ValidTriangles(int a, int b, int c)

        {
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                return 0;
            }
            else
                return 1; ;
        }
         
    }
}
