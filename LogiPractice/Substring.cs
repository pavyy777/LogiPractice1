using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
  
   public static class Substring
    {
        public static void FindAllSubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j <= str.Length; j++)
                {
                    Console.WriteLine(str.Substring(i, j - i));
                }
            }
        }
        


    }

}
