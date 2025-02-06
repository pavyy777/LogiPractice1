using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class CubicDice
    {
        public int OppositeFace(int n)
        {
            //int ans = 7 - n;
            //Console.Write(ans);

            if (n == 1)
            {
                return 6;

            }  
            else if (n == 2)
            {
                return 5;
            }
            else if(n==3 )
            {
                return 4;
            }
            else if (n == 4)
            {
                return 3;
            }
            else if (n == 5)
            {
                return 2;
            }
            else 
            {
                return 1;
            }
            Console.ReadLine();
        }
    }
}
