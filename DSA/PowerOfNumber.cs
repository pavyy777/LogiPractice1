using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class PowerOfNumber
    {
        public void PowerOfNumbers()
        {
            int x = 2, y = 64;//xN=y;
            if (x > 1 && y > 1)
            {
                while (y % x == 0)
                {

                    y = y / x;
                }
            }

            if (y == 1)
            {
                Console.WriteLine("it is power number");
            }
            else
            {
                Console.WriteLine("its not");//pavanj upadhye im n
            }
        }
    }
}
