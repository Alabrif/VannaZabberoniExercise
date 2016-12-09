using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinaTreNumeriInOrdineCrescente
{
    class OrdinaTreNumeri
    {
        /*
         * PRENDERE IN INPUT TRE NUMERI E ORDINARLI IN ORDINE CRESCENTE 
         */
        static void Main ( string[] args )
        {
            int a = Convert.ToInt32( Console.ReadLine() );
            int b = Convert.ToInt32( Console.ReadLine() );
            int c = Convert.ToInt32( Console.ReadLine() );

            int numeroMaggiore = 0;
            int numeroMinore = 0;
            int numeroMedio = 0;

            //a = 5; b = 2; c = 4

            if ( a > b  )
            {
                if ( a > c )
                {
                    if ( c > b )
                    {
                        numeroMaggiore = a;
                        numeroMedio = c;
                        numeroMinore = b;
                    }
                    else
                    {
                        numeroMaggiore = a;
                        numeroMedio = b;
                        numeroMinore = c;
                    }
                }
            }

            if ( b > a )
            {
                if ( b > c )
                {
                    if ( c > a )
                    {
                        numeroMaggiore = b;
                        numeroMedio = c;
                        numeroMinore = a;
                    }
                    else
                    {
                        numeroMaggiore = b;
                        numeroMedio = a;
                        numeroMinore = c;
                    }
                }
            }

            if ( c > a )
            {
                if ( c > b )
                {
                    if ( b > a )
                    {
                        numeroMaggiore = c;
                        numeroMedio = b;
                        numeroMinore = a;
                    }
                    else
                    {
                        numeroMaggiore = c;
                        numeroMedio =a;
                        numeroMinore = b;
                    }
                }
            }

            Console.WriteLine($"{numeroMaggiore} {numeroMedio} {numeroMinore}");
        }
    }
}
