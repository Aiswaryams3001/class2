using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class paraconstructor
    {
        public int a, b;
        public paraconstructor(int x, int y)
        {
            a = x;
            b = y;
        }
        class MainClass
        {
            static void Main()
            {
                paraconstructor v = new paraconstructor(100, 175);
                Console.WriteLine("-----------parameterized Constructor example of Vithal wadje-----------------");
                Console.WriteLine("\t");
                Console.WriteLine("value of a=" + v.a);
                Console.WriteLine("value of b=" + v.b);
                Console.Read();
            }
        }
    }
}
