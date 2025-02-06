using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    internal class Sample
    {
        public Sample()
        {

            //character occurence
            string input = "Never Give up";

            Dictionary<char, int> dict = new Dictionary<char, int>();


            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1; 
                }
            }
            foreach(var v in dict)
            {
                Console.WriteLine( $"{v.Key} is {v.Value} times occured");
            }
        }

    }
}
