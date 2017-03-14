#region #fileheader
// Sebastiano GaudeanoEsCSharpUtilForDelegatesCarDb.cs1411:48
#endregion
using System;
using System.Collections.Generic;

namespace UtilForDelegates
{
    public class CarDb
    {
        public IEnumerable<Car> Cars { get; set; }

        public CarDb ()
        {
            Cars = GenerateDbCar();
        }

        private Random myRand = new Random();

        private List<Car> GenerateDbCar ()
        {
            List<string> carName = GetCarName();
            List<string> carModel = GetCarModel();
            List<int> carYears = GetCarYears();
            List<decimal> carPrice = GetCarPrice();

            List<Car> cars = new List<Car>();

            for ( int i = 0 ; i < 10 ; i++ )
            {
                cars.Add( new Car
                {
                    Name = carName[ myRand.Next( 0 , carName.Count ) ] ,
                    Model = carModel[ myRand.Next( 0 , carModel.Count ) ] ,
                    Year = carYears[ myRand.Next( 0 , carYears.Count ) ] ,
                    Price = carPrice[ myRand.Next( 0 , carPrice.Count ) ]
                } );
            }


            return cars;
        }

        /// <summary>
        /// Get List with random-generated price of car between 15.000 and 70.000
        /// </summary>
        /// <returns>a List of carPrice</returns>
        public List<decimal> GetCarPrice ()
        {
            List<decimal> carPrice = new List<decimal>();

            for ( int i = 0 ; i < myRand.Next( 0 , 15 ) ; i++ )
            {
                carPrice.Add( myRand.Next( 15000 , 70000 ) );
            }

            return carPrice;
        }


        /// <summary>
        /// Get List with random generated Years between 1900 an 2015
        /// </summary>
        /// <returns>a List of Years int</returns>
        public List<int> GetCarYears ()
        {
            List<int> carYears = new List<int>();

            for ( int i = 0 ; i < myRand.Next( 0 , 15 ) ; i++ )
            {
                carYears.Add( myRand.Next( 1900 , 2015 ) );
            }

            return carYears;
        }


        /// <summary>
        /// Get List with car Model
        /// </summary>
        /// <returns><list type="List of Car Model"</returns>
        public List<string> GetCarModel ()
        {
            List<string> carModel = new List<string>()
            {
                "500",
                "Limited Edition",
                "RAV",
                "Station Wagon",
                "Urban"
            };

            return carModel;
        }

        /// <summary>
        /// Get a list with most common car Name
        /// </summary>
        /// <returns></returns>
        public List<string> GetCarName ()
        {
            List<string> carName = new List<string>()
            {
                "Mercedes",
                "Mazda",
                "Renault",
                "BMW",
                "Fiat"
            };

            return carName;
        }
    }
}