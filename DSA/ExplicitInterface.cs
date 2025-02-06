using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Basics
{
     interface IA
    {
        void show();
        
    }
    interface IB
    {
        void show();

    }
    public class DerivedClass:IA,IB
    { 
       void IA.show()
        {
            Console.WriteLine("it is class A");
        }
        void IB.show()
        {
            Console.WriteLine("it is class B");
        }
    }
    
}
