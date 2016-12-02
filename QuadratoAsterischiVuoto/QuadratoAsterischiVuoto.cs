using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratoAsterischiVuoto
{
    class QuadratoAsterischiVuoto
    {
        static void Main(string[] args)
        {
            int lato = 10;

                //TODO: FOR CHE STAMPA IL PRIMO LATO DEL QUADRATO:
                for (int j = 0; j < lato; j++)
                {
                    Console.Write("\t*");
                }
                //TODO: STAMPA DEL PRIMO ASTERISCO
                
                for (int w = 0; w < lato; w++)
                {
                    Console.Write("\n\t*");
                    for (int k = 0; k < lato-2; k++)
                    {
                        Console.Write("\t");
                    }
                    //TODO: STAMPA DELL'ULTIMO ASTERISCO
                    Console.Write("\t*");
                    Console.WriteLine("");
                }
            //TODO: STAMPA DEGLI SPAZI TRA UN ASTERISCO E L'ALTRO
            for (int j = 0; j < lato; j++)
            {
                Console.Write("\t*");
            }
            Console.Read();
        }
    }
}
