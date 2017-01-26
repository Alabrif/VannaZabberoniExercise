using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValoriRef
{
    class SwapValoriRef
    {
        static void Main ( string[] args )
        {
            int primoNumero = 21;
            int secondoNumero = 33;

            Console.WriteLine("Prima dello swap: X: {0}, Y; {1}", primoNumero, secondoNumero);

            SwapValori( ref primoNumero , ref secondoNumero );

            Console.WriteLine( "Dopo lo swap: X: {0}, Y; {1}" , primoNumero , secondoNumero );
        }
       
        /// <summary>
        /// Metodo per cambiare il valore di due variabili
        /// </summary>
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        private static void SwapValori ( ref int primoNumero , ref int secondoNumero )
        {
            int temp = 0;
            temp = primoNumero;
            primoNumero = secondoNumero;
            secondoNumero = temp;
        }
    }
}
