using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangoloDiFloyd
{
    class TriangoloDiFloyd
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write($"\t{k}");
                    k++;
                }
                WriteLine();
            }

            Read();
        }
    }
}
