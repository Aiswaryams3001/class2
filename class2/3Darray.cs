using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class _3Darray
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2,2,3] 
            {
                {{1,2,3},{4,5,6}},
                {{7,8,9},{10,11,12}}
            };
            Console.WriteLine(array[1,1,1]);
            Console.ReadLine();
        }
    }
}
