using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariODispari
{
    class PariODispari
    {
        static void Main ( string[] args )
        {
            /* PRENDERE IN INPUT DIECI VALORI E DETERMINARE
             * QUANTI SONO PARI
             * QUANTI SONO DISPARI
             * LA SOMMA DI TUTTI I VALORI
             * LA MEDIA DI TUTTI I VALORI
             * 
             * REGOLE:
             *      [X]NON POSSONO ESSERE INSERITI NUMERI NEGATIVI
             *      [X]NON POSSONO ESSERE INSERITI PIU' DI 6 NUMERI PARI/DISPARI CONSECUTIVAMENTE.
             *      [X]NON PUO' ESSERE INSERITO IL NUMERO 0
             */

            /* COSA MI SERVE?
             *      [X]UNA VARIABILE PER CONTEGGIARE I DISPARI
             *      [X]UNA VARIABILE PER CONTEGGIARE I PARI
             *      [X]UNA VARIABILE CHE FACCIA LA SOMMA DI TUTTI I VALORI
             *      [X]UNA VARIABILE CHE MI CONTEGGI I NUMERI INSERITI PER FARNE POI LA MEDIA
             *      [X]UNA VARIABILE CHE MI CONTEGGI QUANTI NUMERI
             *         PARI O DISPARI HO INSERITO CONSECUTIVAMENTE
             *      [X]UN CONTROLLO PER IL QUALE NON POSSO INSERIRE IL NUMERO 0
             *      [X]UN CICLO FOR PER INSERIRE I NUMERI(TUTTO AVVIENE DENTRO IL CICLO FINO 
             *         A CHE NON HO INSERITO TUTTI I NUMERI)
             *         
             *      [x] A posto
             */

            int numeriPari = 0;
            int numeriDispari = 0;
            int sommaNumeri = 0;
            int contaMedia = 0;
            int pariConsecutivi = 0;
            int dispariConsecutivi = 0;

            for ( int i = 0 ; i < 10 ; i++ ) //POSSO USARE UN FOR PERCHÈ SO QUANTE VOLTE DEVO FARE IL CICLO
            {
                Console.WriteLine($"Inserisci il {i+1}° Numero:");
                int scelta = Convert.ToInt32( Console.ReadLine() );
                int resto = scelta % 2;
                if ( scelta != 0 && scelta > 0 )
                {
                    if ( pariConsecutivi < 6 && dispariConsecutivi < 6 )
                    {

                        if ( resto == 0 )
                        {
                            numeriPari++;
                            pariConsecutivi++;
                            dispariConsecutivi = 0;
                        }
                        else
                        {
                            numeriDispari++;
                            dispariConsecutivi++;
                            pariConsecutivi = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hai inserito troppi numeri Pari o dispari consecutivamente\n"
                            +"Ora partirai dall'inizio!!!");
                        Main( args );
                    }

                    contaMedia++;
                    sommaNumeri += scelta;
                }
                else
                {
                    Console.WriteLine("Hai inserito lo zero! O un numero negativo! tutto da rifare!!");
                    Main( args );//RICHIAMO IL MAIN, L'APPLICAZIONE RIPARTE DA CAPO
                }
            }

            
            Console.WriteLine($"Hai inserito:\n{numeriDispari}: Numeri Dispari"+
                $"\n{numeriPari}: Numeri Pari"+
                $"\nLa somma di tutti i numeri è: {sommaNumeri}"+
                $"\nLa Media di tutti i numeri inseriti è: {sommaNumeri/contaMedia}" );

            Console.Read();
        }
    }
}
