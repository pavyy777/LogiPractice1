using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiPractice
{
    class RightAngleTriangle
    {
        public RightAngleTriangle()
        {
            Console.WriteLine("enter a row num");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rowNum; i++)
            {
                for (int j = 0; j <=i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                }
             Console.ReadLine();
        }
        public void MirrorRightAngle()
        {
            Console.WriteLine("enter a row num");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rowNum; i++)
            {

                for (int k = rowNum - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
