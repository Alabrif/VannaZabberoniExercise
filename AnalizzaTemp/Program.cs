using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizzaTemp
{
    class Program
    {
        static void Main ( string[] args )
        {

            const int TEMP_MAX = 50;
            const int TEMP_MIN = -50;

            int[] temp = new int[ 15 ];

            int min = 0;
            int max = 0;

            Random myRand = new Random();

            for ( int i = 0 ; i < 15 ; i++ )
            {
                temp[ i ] = myRand.Next( TEMP_MIN, TEMP_MAX );
            }
            foreach ( var temperatura in temp )
            {
                int i = 1;
                Console.WriteLine("Item numero : {0} = {1}\n", i++,  temperatura );
            }

            double media = AnalizzaTemp(temp, out min, out max);

            Console.WriteLine("La media delle temperature è {0}\nLa temperatura massima: {1}\nLa temperatura minima: {2}", media, max, min);

        }

        static double AnalizzaTemp (int []t, out int min, out int max)
        {
            min = 50;
            max = 0;
            double media = 0.0;
            foreach ( var temp in t )
            {
                if ( temp < min )
                {
                    min = temp;
                }
                else
                {
                    if ( temp > max )
                    {
                        max = temp;
                    }
                }
                media += temp;
            }

            return media / t.Length;
        }
    }
}
