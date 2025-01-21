using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LogiPractice
{
     

    class AsyncProgramming
    {
        public static void AsyncProgramming1()
        {
            var Task1 = AsyncProgramming.method1();
        var Task2 = AsyncProgramming.method2();
        var Task3 = AsyncProgramming.method3();
        Task.WaitAll(Task1, Task2, Task3);

        }
        
        public static async Task method1()
        {
            await Task.Delay(2000);
            
            Console.WriteLine("method 1"); 
            
            
        }
        public static async Task method2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(9000);
                Console.WriteLine("method 2");
            });
           

        }
        public static async Task method3()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("method 3");
            });

          }
    }
    }


