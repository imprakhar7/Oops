using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.ReadKey(); 
        }
    }


    class A
    {
        public A()
        {
            Console.WriteLine("This is A");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("This is B");
        }
    }


    

    interface TestInterface
    {

    }




}
