using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ValoreMinimoMassimoChiusoDalloZero
{
    class ValoreMinimoMassimoChiusoZero
    {
        static void Main(string[] args)
        {
            //TODO: Prendere su i numeri
            WriteLine("Inserire una sequenza di numeri, quando si è soddisfatti digitare 0:");

            int indiceMedia = 0;  //tengo l'indice così poi mi basta dividere la somma per l'indice e ottengo la media
            int numeroMassimo = 0; //NUMERO MASSIMO VERRA' MESSO QUA DENTRO
            int numeroMinimio = 0; //NUMERO MINIMO LO METTO QUA DENTRO
            int somma = 0; //LA SOMMA DI TUTTI I NUMERI INSERITI

            int numeroScelto  = 1; //NUMERO SCELTO LO INIZIALIZZO AD UNO COSI' ENTRA NEL WHILE 

            while (numeroScelto != 0) //SONO DENTRO AL WHILE FINCHE' L'UTENTE NON INSERISCE ZERO
            {
                //TODO: DETERMINARE LA SOMMA LA MEDIA VALORE MINIMO E MASSIMO  
                WriteLine($"Inserire il {indiceMedia + 1}° numero:");
                int result = 1; //VARIABILE PER IL TRYPARSE
                string numeroStringa = ReadLine();
                if (int.TryParse(numeroStringa, out result))
                {
                    numeroScelto = result;


                    if (numeroScelto > numeroMassimo)
                    {
                        numeroMassimo = numeroScelto; //SE IL NUMERO CHE SCELGO È MAGGIORE DEL NUMERO MASSIMO FINO A QUEL MOMENTO LO REGISTRO
                    }
                    else if (numeroScelto < numeroMinimio)
                    {
                        numeroMinimio = numeroScelto; //SE IL NUMERO CHE SCELGO È MINORE DEL NUMERO PIU' BASSO FINO A QUEL MOMENTO LO REGISTRO
                    }

                    somma += numeroScelto; //SOMMO TUTTI I NUMERI CHE L'UTENTE INSERISCE
                    indiceMedia++; //TENGO TRACCIA DI QUANTI NUMERI L'UTENTE INSERSCI COSì HO L'INDICE PER FARE LA MEDIA
                }
                else
                {
                    //SE IL TRYPARSE VA MALE
                    WriteLine("Hai sbagliato!!!");
                }
            }

            //TODO: STAMPARE LE INFORMAZIONI A VIDEO:

            //CON LA STRING INTERPOLATION POSSO FARE CACLCOLI INLINE DENTRO LE STRINGHE, LO USO AL POSTO DI String.Format()
            WriteLine($"Il numero massimo inserito è: {numeroMassimo}.\n"+
                $"Il numero minimo inserito è: {numeroMinimio}.\n"+
                $"La media dei numeri inserita è: {somma / indiceMedia}.\n"+
                $"La somma dei numeri inseriti è: {somma}");
            ReadLine();
        }
    }
}
