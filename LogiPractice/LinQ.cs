using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class LinQ
    {
        public LinQ()
        {
            //int[] arr = { 2, 12, 5, 6, 9, 7, 21 };
            string[] arr = { "Pavan","Ramesh","Sachya","sagya","pritya"};
            // var a = from i in arr where i >= 5 select i;
            // var a = from i in arr orderby i descending select i;
            //var a = from names in arr where names.Contains("p") select names;
            var a = from names in arr where names.EndsWith("a") select names;

            foreach (var item in a)
            {
                Console.WriteLine(item);

            } Console.ReadLine();

        }
    }
    }

