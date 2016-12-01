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
                WriteLine($"Inserire il{indiceMedia + 1}");

                numeroScelto = Convert.ToInt32(Console.ReadLine());
                if (numeroScelto > numeroMassimo)
                {
                    numeroScelto = numeroMassimo;
                }
                else if (numeroScelto < numeroMinimio)
                {
                    numeroMinimio = numeroScelto;
                }

                somma += numeroScelto;
                indiceMedia++;
            }

            //TODO: STAMPARE LE INFORMAZIONI A VIDEO:

            WriteLine($"Il numero massimo inserito è: {numeroMassimo}. \nIl numero minimo inserito è: {numeroMinimio}.\nLa media dei numeri inserita è: {somma / indiceMedia}. \nLa somma dei numeri inseriti è: {somma}");
        }
    }
}
