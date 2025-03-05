using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace LogiPractice
{
    class Array
    {
        public int[] ArraySample()
        {
            int oddCount = 0;
            int evenCount = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i=0; i<=arr.Length-1;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            return new int[] { evenCount, oddCount };
            Console.ReadLine();
        }
        public int ArrayAvg()
        {
            int[] arr1 = { 1, 2, 2, 2, 5 };
            int sum = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                sum = sum + arr1[i];
            }

            int counts = arr1.Length;
             int result = sum / counts;
            return result;
           
        }
        public void ArrayWordCovert()
        {
            string N = "123";
            Dictionary<char, string> Dict = new Dictionary<char, string>();
            Dict.Add( '1', "Öne");
            Dict.Add('2', "two"); Dict.Add('3', "three"); Dict.Add('4', "four"); Dict.Add('5', "five");
               
            foreach(char num in N)
            {
                Console.WriteLine(Dict[num] +"");
            }
            Console.ReadLine();
        }
    }
}
