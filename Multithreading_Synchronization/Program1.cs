using System.Threading;
namespace Multithreading_Synchronization
{
    class Program1
    {
        private static readonly Mutex mutex = new Mutex(false, "Global\\MyUniqueMutexName");
     //   private static Mutex mutex=new Mutex(false,"Flobal\\MyUniqueMutexName");
        //Mutex object with a unique name, allowing for cross-process locking
        static void Main(string[] args)
        {
            if(!mutex.WaitOne(TimeSpan.FromSeconds(3),false))
            {
                System.Console.WriteLine("Another instance of the application is already running ");
                return ;
                //Exit if another instance is running 
            }
            try
            {
                System.Console.WriteLine("Application is running. Press Enter to exit....");
                System.Console.WriteLine();
                //keep the application running
            }

            finally
            {
                //release the mutex when done
                mutex.ReleaseMutex();
            }
        }
    }
}