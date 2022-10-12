using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class _2Darrayforloop
    {
        static void Main(string[] args)
        {
           int[,] array = new int[3, 2]
           {
                {1,2},{3,4},{5,6}
           };
           Console.WriteLine("2 Dimensional Array Elements...");
           for (int i = 0; i <3; i++)
            {
                for(int j = 0; j <2; j++)
                {
                    Console.WriteLine("a[{0},{1}]={2}", i, j, array[i,j]);
                }
               
            }
            //Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
