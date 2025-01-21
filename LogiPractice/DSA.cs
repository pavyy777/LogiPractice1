using LanguageExt.UnitsOfMeasure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class DSA
    {
        public void VowelFind()
        {
            int count = 0;
            string str = "pavan upadhye";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }

            } Console.WriteLine("vowels are" + count);
            Console.ReadLine();
        }
        public void PerfectSquare()
        {
            int N = 34;
            double r = Math.Sqrt(N);

            if (r == (int)r)
            {
                Console.WriteLine("its a perfect square number");
            }
            else
            {
                Console.WriteLine("not");


            }
        }
        public void SumOfDigits()
        {
            int n = 2345;
            int sum = 0, r;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;


            }
            Console.WriteLine(sum); Console.ReadLine();
        }
        public void factorial()
        {
            int n = 5;
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                 fact = fact * i;
                
            }
            Console.WriteLine(fact);
        }
        public void AscendingOrNot()
        {
            
            int[] arr = { 1, 2,3,4};
            int[] sortedArr = (int[])arr.Clone();
            System.Array.Sort(sortedArr);
            if (arr.SequenceEqual(sortedArr))
            {
                Console.WriteLine("its sorted");
            }
            else
            {
                Console.WriteLine("not sorted");
            }
        }
        public void multiplicationtable()
        {
            int n = 5;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+ "*"+ i +"="+ n*i);

            }
            Console.ReadLine();
        }
        public void revString()
        {
            int n = 1234;
            string str = Convert.ToString(n);
            string ReversString = "";
            int length = str.Length - 1;

            for (  int i=length;i>=0;i--)         
                {
                ReversString = ReversString + str[i];
               // length--;
            }
             n= Convert.ToInt32(ReversString);
            Console.WriteLine(n);
            Console.ReadLine();
        }
        public void SecondLargest()
        {
            int[] arr = { 2, 6, 8, 9, 3 };
            System.Array.Sort(arr);
            System.Array.Reverse(arr);
            Console.WriteLine(arr[1]);
            Console.ReadLine();
        }
        public void LargestWord()
        {
            string input = "i am pavan bahubali Upadhye";
            string LongestName = "";
           
            string[] words = input.Split(' ');
           
            foreach (string word in words)
            {
                if (word.Length > LongestName.Length)
                {
                    LongestName = word;
                }
            }
            Console.WriteLine(LongestName);
            Console.ReadLine();
        }
} }


