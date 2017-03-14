#region #fileheader
// Sebastiano GaudeanoEsCSharpTerzoTentativoDelegatiPerfomCalculationOnCar.cs1412:44
#endregion

using System;
using System.Collections.Generic;
using UtilForDelegates;

namespace TerzoTentativoDelegati
{
    public class PerfomCalculationOnCar
    {
        public static void StampCarName ( Car car )
        {
            Console.WriteLine( car.Name );
        }

        public static void StampCarModel ( Car car )
        {
            Console.WriteLine( car.Model );
        }

        public static void StampCarPrice ( Car car )
        {
            Console.WriteLine( "Car Name: " + car.Name + " Price: " + car.Price );
        }

        public static decimal CalculateTotalPriceOfCar ( List<Car> cars )
        {
            decimal price = 0;

            foreach ( Car car in cars )
            {
                price += car.Price;
            }

            return price;
        }
    }
}