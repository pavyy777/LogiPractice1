using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogiPractice.Delegates;

namespace LogiPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinQ linq = new LinQ();

            DSA dsa = new DSA();
            //dsa.LargestWord();
            //dsa.revString();
            //dsa.SecondLargest();
            //dsa.AscendingOrNot();
            //dsa.multiplicationtable();

            //dsa.factorial();
            // dsa.VowelFind();
            //dsa.PerfectSquare();
            //dsa.SumOfDigits();
            Array ar = new Array();
            //int[] arrr= ar.ArraySample();
            //Console.WriteLine(ar.ArraySample());
            //Console.WriteLine(arrr[1]+" "+arrr[0]);
            //Console.WriteLine(ar.ArrayAvg());

            //ar.ArrayWordCovert();
            //Console.ReadLine();
            //Delegates del = new Delegates();
            //addnum a = new addnum(del.sum);
            //a(100, 50);
            //AsyncProgramming.AsyncProgramming1();
            //DuplicateRemove duplicateRemove = new DuplicateRemove();
            //ReverseEachWords reverseEachWords = new ReverseEachWords();
            //CharacterOccurence characterOccurence = new CharacterOccurence();
            //RightAngleTriangle rightAngleTriangle = new RightAngleTriangle();
            //rightAngleTriangle.MirrorRightAngle();
            //PalindromeString palindromeString = new PalindromeString();
            //palindromeString.PalidromeStringArray();
            // palindromeString.PalindromeStringForeach();
            // SumOfDigits sumOfDigits = new SumOfDigits();
            //Fibonacci fibonacci = new Fibonacci();

            //PalindromeNumbers palindromeNumbers = new PalindromeNumbers();

            //PrimeNumbers primeNumbers = new PrimeNumbers();
            // Sample sample = new Sample();
            string input = "abc";

            Substring.FindAllSubstrings(input);
            largestNumber.execute();
            Console.ReadLine();

        }
    }
}
;