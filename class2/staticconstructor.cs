using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class staticconstructor
    {
        public staticconstructor()
        {
            Console.WriteLine("Instance Constructor");
        }
        static staticconstructor()
        {
            Console.WriteLine("Static Constructor");
        }
        class staticcheck
        {
            static void Main()
            {
                //Static Constructor and Instance Constructor, both are invoked for first instance.
                staticconstructor T1 = new staticconstructor();
                //Only instance constructor is invoked.
                staticconstructor T2 = new staticconstructor();

                Console.Read();
            }
        }
    }
}
