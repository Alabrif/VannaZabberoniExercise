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
            int result; //VARIABILE PER IL TRYPARSE
            int righe; //RIGHE DEL TRIANGOLO DI FLOYD
            if (int.TryParse(Console.ReadLine(), out result))
            {
                righe = result;

                int k = 1; //CONTATORE CHE STAMPA I NUMERI
                for (int i = 0; i <= righe; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        //STAMPO LE RIGHE
                        Write($"\t{k}");
                        k++;
                    }
                    //VADO A CAPO
                    WriteLine();
                }

                Read();
            }
            else
            {
                //NEL CASO IN CUI NON RIUSCISSI A CONVERTIRE RIGHE
                WriteLine("Hai sbagliato!");
                Main(args);
            }
        }
    }
}
