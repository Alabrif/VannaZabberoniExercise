using System;
using UtilForDelegates;


namespace TesUtilForDelegates
{
    class Program
    {
        static void Main ( string[] args )
        {

            CarDb carDb = new CarDb();

            foreach ( Car car in carDb.Cars )
            {
                Console.WriteLine( car );
            }

            Console.ReadLine();
        }
    }
}
