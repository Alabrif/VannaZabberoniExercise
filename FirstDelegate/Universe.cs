using System;

namespace FirstDelegate
{
    public class Universe
    {
        public static void WorkerStartedWork ()
        {
            Console.WriteLine( "Universe notices worker starting work" );
        }

        public static int WorkerCompletedWork ()
        {
            System.Threading.Thread.Sleep( 4000 );
            Console.WriteLine( "Universe pleased with worker's work" );
            return 7;
        }


    }
}