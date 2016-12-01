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
            WriteLine("Inserire quante righe si vuole");
            //int righe = Convert.ToInt32(Console.ReadLine())
            int result;
            int righe;
            if (int.TryParse(Console.ReadLine(), out result))
            {
                righe = result;

                int k = 1;
                for (int i = 0; i <= righe; i++)
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
            else
            {
                WriteLine("Hai sbagliato!");
                Main(args);
            }
        }
    }
}
