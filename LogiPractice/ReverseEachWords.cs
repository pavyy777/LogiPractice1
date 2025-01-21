using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class ReverseEachWords
    {
        public ReverseEachWords()
        {
            string input = "Pavan Upadhye";
            string result = ReverseWords(input);
            Console.WriteLine(result); // Output: "olleH dlroW"
        }

        static string ReverseWords(string input)
        {
            // Split the string into words
            string[] words = input.Split(' ');

            // Reverse each word and store it back into the array
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                System.Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            // Join the reversed words back into a single string
            return string.Join(" ", words);
        }
    }
}
