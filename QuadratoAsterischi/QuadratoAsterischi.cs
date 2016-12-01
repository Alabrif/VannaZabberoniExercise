using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace QuadratoAsterischi
{
    class QuadratoAsterischi
    {
        static void Main(string[] args)
        {

            //TODO: INSERIRE IL LATO DEL QUADRATO
            WriteLine("Inserire il lato del quadrato: ");

            int lato = Convert.ToInt32(Console.ReadLine());

            //TODO: STAMPRE IL QUADRATO
            for (int i = 0; i < lato; i++)
            {
                for (int j = 0; j < lato; j++) //STAMPO LA RIGA
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");//VADO A CAPO
            }

            Read();
        }
    }
}
