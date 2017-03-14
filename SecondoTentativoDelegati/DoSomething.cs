using System;

namespace SecondoTentativoDelegati
{
    public class DoSomething
    {

        public static void GetHelloWorld ()
        {
            Console.WriteLine( "Hello: Sconosciuto" );
        }

        public static void GetHelloWorldWithName ( string name )
        {
            Console.WriteLine( "Hello: " + name );
        }

        public static void GetHelloWorldToString ( string param )
        {
            Console.WriteLine( "Hello!" + param );
        }
    }
}