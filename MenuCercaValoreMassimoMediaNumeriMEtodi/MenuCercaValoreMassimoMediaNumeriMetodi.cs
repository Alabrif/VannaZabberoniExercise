using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCercaValoreMassimoMediaNumeriMEtodi
{
    class MenuCercaValoreMassimoMediaNumeriMetodi
    {
        static void Main(string[] args)
        {
            //CONSTANTE PER LA QUANTITA' DI NUMERI DA INSERIRE NELL'ARRAY     
            const int MAX_NUMERI_ARRAY = 10;
            //CREAZIONE DELL'ARRAY
            int[] NUMERI = new int[MAX_NUMERI_ARRAY];
            //POPOLO L'ARRAY CON NUMERI RANDOM
            NUMERI = CreaArrayNumeriRandom(MAX_NUMERI_ARRAY);
            //CREAZIONE DELLA VARIABILE CHE LEGGERA' IL NUMERO DA TASTIERA
            ConsoleKeyInfo scelta;
            //FLAG PER L'USCITA DAL DO-WHILE
            bool continuaEsecuzione = true;
            
            //
            do
            {
                Console.WriteLine("\n");
                //STAMPO A VIDEO IL MENU CON UN METODO FATTO APPOSTA
                StampaMenu();
                //USANDO READKEY LEGGO SOLO IL PRIMO CARATTERE PREVENGO CHE L'UTENTE POSSA INSERIRE PAROLE E ALTRE COSE PERCHè DOPO IL PRIMO CARATTERE LUI PRENDE L'INSERIMENTO
                scelta = Console.ReadKey();
                Console.WriteLine("\n");
                switch (scelta.KeyChar)
                {
                    case '1':
                        string numeroInserito;
                        int numeroInseritoControllato;
                        Console.WriteLine("Inserire il numero da cercare:");
                        if (!int.TryParse(numeroInserito = Console.ReadLine(), out numeroInseritoControllato))
                        {
                            Console.WriteLine("Hai sbagliato a inserire il numero!");
                            break;
                        }
                        bool risultatoRicercaNumero = RicercaDiUnNumero(NUMERI, numeroInseritoControllato);
                        if (risultatoRicercaNumero)
                        {
                            Console.WriteLine("Il numero inserito è presente nell'array");
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case '2':
                        string risultatoValoreMassimo = CalcolaIlValoreMassimo(NUMERI);
                        Console.WriteLine("Il valore massimo è {0} ", risultatoValoreMassimo);
                        break;
                    case '3':
                        string risultatoMediaNumeri = CalcolaMediaNumeri(NUMERI);
                        Console.WriteLine("La media dei numeri è {0}", risultatoMediaNumeri);
                        break;
                    case '4':
                        string numeriDaStampare = ConvertiArrayInStringa(NUMERI);
                        Console.WriteLine("I numeri sono: \n {0}", numeriDaStampare);
                        break;
                    case '0':
                        Console.WriteLine("PREMERE INVIO PER TERMINARE IL PROGRAMMA");
                        continuaEsecuzione = false;
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (continuaEsecuzione);
            
        }

        private static int[] CreaArrayNumeriRandom(int elementiArray)
        {
            Random myRand = new Random();
            int[] someArray = new int[elementiArray];
            for (int i = 0; i < elementiArray; i++)
            {
                someArray[i] = myRand.Next(0, 500);
            }

            return someArray;
        }

        private static string ConvertiArrayInStringa(int[] NUMERI)
        {
            StringBuilder ArrayinStringa = new StringBuilder();

            foreach (var item in NUMERI)
            {
                ArrayinStringa.AppendFormat(" ,", item);
            }

            return ArrayinStringa.ToString();
        }

        private static string CalcolaMediaNumeri(int[] NUMERI)
        {
            return NUMERI.Average().ToString();
        }

        private static string CalcolaIlValoreMassimo(int[] NUMERI)
        {
            return NUMERI.Max().ToString();
        }

        private static bool RicercaDiUnNumero(int[] NUMERI, int numeroDaCercare)
        {
            if (NUMERI.Contains(numeroDaCercare))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Stampa il menu per l'esercizio con le opzioni ricerca calcolo e media del un numero
        /// </summary>
        static void StampaMenu()
        {
            Console.WriteLine("1 - Ricerca di un certo numero.");
            Console.WriteLine("2 - Calcolo del valore massimo.");
            Console.WriteLine("3 - Calcolo della media dei numeri.");
            Console.WriteLine("4 - Stampa Gli elementi dell'array a video.");
            Console.WriteLine("0 - Termina il programma.");
        }
    }
}
