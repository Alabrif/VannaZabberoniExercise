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

            int soprazero = 0;
            int sottozero = 0;
            int temperaturaTotale = 0;

            for (int i = 0; i < 10; i++)
            {
                int temperatura = Convert.ToInt32(Console.ReadLine());
                //TODO: DETERMINARE LE TEMPERATURE ALTE E BASSE
                if (temperatura >= 0)
                {
                    soprazero += 1;
                }
                else
                {
                    sottozero += 1;
                }

                temperaturaTotale += temperatura;
            }

            WriteLine($"Le temperature registrate sono:\n Maggiori di zero: {soprazero}. \nInferiori a zero: {sottozero}. \nLa temperatura media è: {temperaturaTotale/10}");
            ReadLine();
        }
    }
}
