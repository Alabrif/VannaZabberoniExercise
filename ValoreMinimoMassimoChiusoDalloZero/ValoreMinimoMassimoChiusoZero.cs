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
            int numeroMassimo = 0;
            int numeroMinimio = 0;
            int somma = 0;

            int numeroScelto  = 1;

            while (numeroScelto != 0)
            {
                //TODO: DETERMINARE LA SOMMA LA MEDIA VALORE MINIMO E MASSIMO  
                WriteLine($"Inserire il {indiceMedia + 1}° numero:");
                int result = 1;
                string numeroStringa = ReadLine();
                if (int.TryParse(numeroStringa, out result))
                {
                    numeroScelto = result;


                    if (numeroScelto > numeroMassimo)
                    {
                        numeroMassimo = numeroScelto;
                    }
                    else if (numeroScelto < numeroMinimio)
                    {
                        numeroMinimio = numeroScelto;
                    }

                    somma += numeroScelto;
                    indiceMedia++;
                }
                else
                {
                    WriteLine("Hai sbagliato!!!");
                }
            }

            //TODO: STAMPARE LE INFORMAZIONI A VIDEO:

            WriteLine($"Il numero massimo inserito è: {numeroMassimo}.\n"+
                $"Il numero minimo inserito è: {numeroMinimio}.\n"+
                $"La media dei numeri inserita è: {somma / indiceMedia}.\n"+
                $"La somma dei numeri inseriti è: {somma}");
            ReadLine();
        }
    }
}
