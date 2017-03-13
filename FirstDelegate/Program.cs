using System;

namespace FirstDelegate
{

    public class Program
    {
        public static void Main ()
        {
            Worker peter = new Worker();
            Boss boss = new Boss();
            peter.Completed += boss.WorkCompleted;
            peter.Started += Universe.WorkerStartedWork;
            peter.Completed += Universe.WorkerCompletedWork;
            peter.DoWork();

            Console.WriteLine( "Main: worker completed work" );

            Console.Read();
        }
    }

}
