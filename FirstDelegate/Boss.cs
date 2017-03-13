using System;

namespace FirstDelegate
{
    public class Boss
    {
        public int WorkCompleted ()
        {
            System.Threading.Thread.Sleep( 3000 );
            Console.WriteLine( "Better..." );
            return 5; // out of 10
        }
    }
}