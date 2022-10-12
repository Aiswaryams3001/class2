using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class _2Darray
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 2]
            {
                {1,2},{3,4},{5,6}
            };

            Console.WriteLine(array[0,0]);
            Console.WriteLine(array[0,1]);
            Console.WriteLine(array[1,0]);
            Console.WriteLine(array[1,1]);
            Console.WriteLine(array[2,0]);
            Console.WriteLine(array[2,1]);
            //Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
