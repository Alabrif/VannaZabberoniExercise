using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomboAsterischi
{
    class TriangoloAsterischi
    {
        static void Main(string[] args)
        {
            int countSpazi = 50;
            int countAsterischi = 0;
            //TODO: FOR CHE VA A CAPO
            for (int i = 0; i <= 20; i++)
            {
                //TODO: FOR CHE STAMPA GLI SPAZI
                for (int k = 0; k < countSpazi; k++)
                {
                    Console.Write(" ");
                }
                //TODO: FOR CHE STAMPA GLI ASTERISCHI
                for (int j = 0; j <= countAsterischi; j++)
                {
                    Console.Write("*");
                }

                countSpazi--;//DMINUISCO IL VALORE DEGLI SPAZI COSI' STAMPA UNO SPAZIO IN MENO
                countAsterischi+=2; //AUMENTO IL VALORE DEGLI ASTERISCHI COSì STAMPA DUE ASTERISCHI IN PIU'
                Console.WriteLine("");//VADO A CAPO PER CREARE LA NUVA LINEA
            }
            Console.Read();
        }
    }
}
