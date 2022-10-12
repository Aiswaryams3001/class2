using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class Addition
    {
        int a, b;
        public Addition() //default Constructor
        {
            a = 100;
            b = 175;
        }
        public static void Main()
        {
            Addition obj=new Addition();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}
