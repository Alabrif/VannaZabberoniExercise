using System;
using System.Collections.Generic;

namespace SecondoTentativoDelegati
{

    public class Program
    {
        //public delegate void SayHelloToMe ();

        //public delegate void SayHelloToMeWithMyName ( string name );

        public delegate IEnumerable<Car> FilterCar ( string param );
        static void Main ( string[] args )
        {
            /*
            SayHelloToMe sayHello = new SayHelloToMe( DoSomething.GetHelloWorld );
            SayHelloToMeWithMyName sayMyName = new SayHelloToMeWithMyName( DoSomething.GetHelloWorldWithName );
            sayHello();
            
            sayMyName += DoSomething.GetHelloWorldToString;
            sayMyName( "Sebastiano" );*/

            CarRepo myCars = new CarRepo();

            foreach ( Car car in myCars.GetCarsDB() )
            {
                Console.WriteLine( "Macchina {0}, Modello {1}" , car.Name , car.Model );
            }

            FilterCar myDelegate = new FilterCar( myCars.FilterCarByModel );

            var myFilteredCar = myDelegate( "A72" );
            Console.WriteLine( "\n\n" );
            Console.WriteLine( myDelegate.Method );
            foreach ( Car car in myFilteredCar )
            {
                Console.WriteLine( "Macchina {0}, Modello {1}" , car.Name , car.Model );
            }

            myDelegate = myCars.FilterCarByName;

            myFilteredCar = myDelegate( "Ciccio" );
            Console.WriteLine( "\n\n" );
            Console.WriteLine( myDelegate.Method );
            foreach ( Car car in myFilteredCar )
            {
                Console.WriteLine( "Macchina {0}, Modello {1}" , car.Name , car.Model );

            }

            //Func<string, List<Car>> FilterCar;

            Console.ReadLine();
        }



    }
}


