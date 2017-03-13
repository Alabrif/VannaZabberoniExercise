using System;

namespace FirstDelegate
{
    public class Worker
    {

        public delegate void WorkStarted ();
        public delegate void WorkProgressing ();
        public delegate int WorkCompleted ();

        public event WorkStarted Started;
        public event WorkProgressing Progressing;
        public event WorkCompleted Completed;

        public void DoWork ()
        {
            Console.WriteLine( "Worker: work started" );
            if ( this.Started != null )
                this.Started();

            Console.WriteLine( "Worker: work progressing" );
            if ( this.Progressing != null )
                this.Progressing();

            Console.WriteLine( "Worker: work completed" );
            if ( this.Completed != null )
            {
                foreach ( WorkCompleted wc in this.Completed.GetInvocationList() )
                {
                    WorkCompleted wc2 = wc;
                    wc.BeginInvoke( delegate ( IAsyncResult result )
                        {
                            int grade = wc2.EndInvoke( result );
                            Console.WriteLine( "Worker grade= {0}" , grade );
                        } ,
                        null );
                }
            }
        }
    }
}