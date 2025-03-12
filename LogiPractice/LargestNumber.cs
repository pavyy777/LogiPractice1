using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    using LanguageExt;
    using System;

    public static class largestNumber
    {
        static int FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)  // Found new largest number
                {
                    secondLargest = largest;  // Update second largest
                    largest = num;  // Update largest
                }
                else if (num > secondLargest && num != largest)  // Found second largest
                {
                    secondLargest = num;
                }
            }
            return secondLargest;
        }


        public static int FindThirdLargest(int[] arr)
        {
            int first = int.MinValue, second = int.MinValue, third = int.MinValue;

            foreach (int num in arr)
            {
                if (num > first)  // Found new largest
                {
                    third = second;
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)  // Found second largest
                {
                    third = second;
                    second = num;
                }
                else if (num > third && num != second && num != first)  // Found third largest
                {
                    third = num;
                }
            }
            return third;




        }


        public static void execute()
        {
            int[] arr = { 10, 5, 8, 20, 15 };
            Console.WriteLine("Second Largest: " + FindSecondLargest(arr));

            Console.WriteLine("Third Largest: " + FindThirdLargest(arr));
        }

    }
}

