using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class CharacterOccurence
    {
        public CharacterOccurence()
        {
            string input = "hello world im pavan here";
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            // Loop through each character in the input string
            foreach (char word in input)
            {
                // Check if the character already exists in the dictionary
                if (characterCount.ContainsKey(word))
                {
                    characterCount[word]++;
                }
                else
                {
                    characterCount[word] = 1;
                }
            }

            // Display the result
            Console.WriteLine("Character occurrences:");
            foreach (var item in characterCount)
            {
                Console.WriteLine($"Character '{item.Key}' occurs {item.Value} times.");
            }
            Console.ReadLine();
        }
    }
}
