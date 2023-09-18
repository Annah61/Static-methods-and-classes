using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods_and_classes
{
    internal class sayHi
    {
        public static void sayHello(string name) 
        {
            Console.WriteLine("Hello" + name);

            //freeze 
            Console.ReadLine();

        }
    }
}
