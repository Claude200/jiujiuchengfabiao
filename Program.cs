using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(string.Format("{0}*{1}={2}", i, j, i * j));
                    //Console.Write($"{ i }*{ j }={ i*j }");    C#6.0以上的版本支持
                Console.WriteLine();
            }
         }
    }
}
