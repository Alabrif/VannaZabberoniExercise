using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsCSharp;

namespace EsCSharp
{
    public class GestioneTemperature
    {
        private int max = 0;
        private int min = 0;

        private int _numeroTemperatureDaGenerare;

        public int numeroTemperatureDaGenerare
        {
            get { return _numeroTemperatureDaGenerare; }
            set { _numeroTemperatureDaGenerare = value; }
        }

        /// <summary>
        /// Fornire la quantità di temperature da generare, il valore massimo della temperature e il valore minimo
        /// </summary>
        /// <param name="quantita"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public GestioneTemperature (int quantita, int max, int min)
        {
            numeroTemperatureDaGenerare = quantita;
            this.max = max;
            this.min = min;
        }


        Random myRand = new Random();
        public int[] GetTemeperature ()
        {
            int[] temperature = new int[max];
            for ( int i = 0 ; i < max ; i++ )
            {
                temperature[ i ] = myRand.Next( min , max );
            }

            return temperature;
        }

        /// <summary>
        /// Analizza un array di temperature e restituisce i valore di temperatura media massima e minima
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="media"></param>
        /// <returns></returns>
        public bool AnalizzaTemp (int[] temp, out int min, out int max, out double media)
        {
            min = this.max;
            max = this.min;
            media = 0.0;
            foreach ( var t in temp )
            {
                if ( t < min )
                {
                    min = t;
                }
                else
                {
                    if ( t > max )
                    {
                        max = t;
                    }
                }
                media += t;
            }

            if ( min > max )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
