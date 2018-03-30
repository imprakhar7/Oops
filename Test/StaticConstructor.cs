using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class StaticConstructor
    {
        public StaticConstructor()
        {
            Console.WriteLine("This is PublicConstructor");
        }
        static StaticConstructor()
        {
            Console.WriteLine("This is StaticConstructor");
        }
    }

    public class StaticConstructorOne : StaticConstructor
    {
        public StaticConstructorOne()
        {
            Console.WriteLine("This is PublicConstructorOne");
        }
        static StaticConstructorOne()
        {
            Console.WriteLine("This is StaticConstructorOne");
        }


    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            var sc = new StaticConstructorOne();
            Console.ReadKey();
        }
    }


    //A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only.
    //    It is called automatically before the first instance is created or any static members are referenced.


}
