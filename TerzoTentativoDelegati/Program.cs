using System;

namespace TerzoTentativoDelegati
{
    public class Program
    {
        public static void Main ( string[] args )
        {

            TerzoTentativoCarDb CarDb = new TerzoTentativoCarDb();

            CarDb.GiveMeCarToProcess( new TerzoTentativoCarDb.ProcessCarDelegate( PerfomCalculationOnCar.StampCarModel ) );
            Console.WriteLine( "\n\n" );
            CarDb.GiveMeCarToProcess( new TerzoTentativoCarDb.ProcessCarDelegate( PerfomCalculationOnCar.StampCarName ) );
            Console.WriteLine( "\n\n" );
            CarDb.GiveMeCarToProcess( new TerzoTentativoCarDb.ProcessCarDelegate( PerfomCalculationOnCar.StampCarPrice ) );
            Console.Read();
        }
    }
}
