using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringraDiAsterischiDaIntero
{
    class StringaDiAsterischiDaIntero
    {
        static void Main ( string[] args )
        {
            int scelta = 0;
            string stringaAsterischi = Console.ReadLine();
            if ( int.TryParse(stringaAsterischi, out scelta) )
            {
                Console.WriteLine("Molto bene! \n");
            }
            else
            {
                Console.WriteLine("Molto male!!\n");
                Main( args );
            }

            stringaAsterischi = getAsterischiOnString(scelta);

            Console.WriteLine("La stringa fatta di asterischi: " + stringaAsterischi);
        }

        private static string getAsterischiOnString ( int scelta )
        {
            string stringaAsterischi = "";

            for ( int i = 0 ; i < scelta ; i++ )
            {
                stringaAsterischi += "*";
            }
            return stringaAsterischi;
        }
    }
}
