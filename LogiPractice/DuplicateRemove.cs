using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class DuplicateRemove
    {
        public DuplicateRemove()
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString = resultString + inputString[i];
                }
            }
            Console.WriteLine(resultString);

            Console.ReadKey();
        }
       
    }
}
