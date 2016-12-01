using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureAlteBasse
{
    class TemperatureAlteBasse
    {
        static void Main(string[] args)
        {
            //TODO: INSERIRE LE 10 TEMPERATURE
            WriteLine("Inserire 10 temperature:");

            //CREO VARIABILI PER IMMAGAZZINARE I VALORI
            int soprazero = 0;
            int sottozero = 0;
            int temperaturaTotale = 0;

            //CICLO FOR PER INSERIRE LE 10 TEMPERATURE
            for (int i = 0; i < 10; i++)
            {
                int temperatura = Convert.ToInt32(Console.ReadLine());
                //TODO: DETERMINARE LE TEMPERATURE ALTE E BASSE
                if (temperatura >= 0)
                {
                    soprazero += 1; //IMMAGAZZINO LA QUANTITA' DI TEMPERATURE SOPRA LO ZERO
                }
                else
                {
                    sottozero += 1; //IMMAGAZZINARE LA TEMPERATURA SOTTO LO ZERO
                }

                temperaturaTotale += temperatura; // SOMMA LE TEMPERATURE REGISTRATE COSì POI FACCIO LA MEDIA
            }


            //STAMPO TUTTO A VIDEO
            WriteLine($"Le temperature registrate sono:\n Maggiori di zero: {soprazero}. \nInferiori a zero: {sottozero}. \nLa temperatura media è: {temperaturaTotale/10}");
            ReadLine();
        }
    }
}
