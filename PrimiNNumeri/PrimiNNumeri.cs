using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimiNNumeri
{

    /*
     *N.5
        Produrre i primi n numeri delle sequenze:
        -	1, 3, 5, 7, 9, ...
        -	-1, -2, -3, ...
        -	0, 1, 4, 9, 16, 25, 36, 49, ...
        -	1, 2, 4, 8, 16, 32, 64, 128, 256, ... 
    */
    class PrimiNNumeri
    {
        static void Main ( string[] args )
        {
            WriteLine( "Inserire un numero, creerò sequenze di numeri per n numeri inseriti " );

            int result;
            string choice = ReadLine();
            //SE IL NUMERO PUO ESSERE CONVERTITO IN STRINGA ALLORA ENTRO NELL'IF
            if ( int.TryParse(choice, out result ))
            {
                WriteLine( "Prima serie di numeri: \n" );
                int j = 1;//CREO J FUORI DAL FOR
                for ( int i = 0 ; i < result ; i++ )
                {
                    Write( $"{j}  " );
                    j += 2;//OGNI CICLO AUMENTO IL VALORE DI J DI 2
                }

                j = -1;

                WriteLine( "\n\nSeconda serie di numeri: \n" );
                for ( int i = 0 ; i < result ; i++ )
                {
                    Write( $"{j}  " );
                    j--; //DIMINUISCO IL VALORE DI J OGNI CICLO.
                }

                WriteLine( "\n\nTerza serie di numeri: \n" );
                //j = 2;
                j = 0;
                for ( int i = 1 ; i <= result ; i++ )
                {
                    //PRIMA SOLUZIONE CON OGGETTO Math(USANDO IL METODO Pow)
                    //j = ( int ) Math.Pow( i , 2 );
                    //Write( $"\t{j}" ); 

                    //SECONDA VERSIONE SENZA OGGETTI 
                    Write( $"  {j}" );
                    j = i * i;
                }


                WriteLine( "\n\nQuarta serie di numeri:" );
                j = 1;
                for ( int i = 1 ; i <= result ; i++ )
                {
                    j = j * 2;
                    Write( $"  {j}" );
                }

            }
            else
            {
                WriteLine( "Ei! ti sei sbagliato a inserire il numero! Riprova!" );
                Main( args );
            }

            Read();
        }
    }
}
