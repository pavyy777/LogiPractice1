using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class PalindromeString
    {
        public PalindromeString()
        {
            string ReversString = "";
            string str = Console.ReadLine();
           
            int length = str.Length - 1;
            string temp = str;

            while (length >= 0)
            {
                ReversString = ReversString + str[length];
                length--;
            }
            if (temp == ReversString)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("not a palindrome");
            Console.ReadLine();
        }
        public void PalindromeStringForeach()
        {
            Console.WriteLine("enter a string");
            string RevString = "";
            string str = Console.ReadLine();
            foreach(char c in str)
            {
                RevString =c + RevString;

            }
            Console.WriteLine("reverse string is "+RevString);
            Console.ReadLine();
        }
        public void PalidromeStringArray()
        {
           // Console.WriteLine("enter a string");
            string str = "aba";
            char[] stringArray = str.ToCharArray();
            //System.Array.Reverse(stringArray);
            stringArray.Reverse();
            string result =  new string(stringArray);
           if (result.Equals(str))
            {
                Console.WriteLine("str is palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            Console.ReadLine();


        }
    }
}
