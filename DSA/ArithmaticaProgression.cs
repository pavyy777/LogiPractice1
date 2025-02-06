using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
    internal class ArithmaticaProgression
    {
        public  bool ArithmaticaProgressions(int[] arr) {
            // 1,4,7,10,14
            if (arr.Length <= 2)
                return false;

                int diff = arr[1] - arr[0];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i + 1] - arr[i] != diff)
                    {
                        return false;
                    }
                }
            
                return true;
            
        }
    }
}
