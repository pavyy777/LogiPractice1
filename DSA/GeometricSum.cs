using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class GeometricSum
    {
        public GeometricSum()
        {
            // a,ar,ar2,ar3,ar4....
            int n = 10, a = 2, r = 3;
            double rslt = a * (1 - Math.Pow(r, n)) / (1 - r);
            Console.WriteLine(rslt);

            
        } }
}
