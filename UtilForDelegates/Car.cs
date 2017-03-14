using System;

namespace UtilForDelegates
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public override string ToString ()
        {
            return String.Format( "Nome macchina: {0} | Modello macchina: {1} | Anno di immatricolazione: {2}| Prezzo: {3}" ,
                Name , Model , Year , Price );
        }
    }
}
