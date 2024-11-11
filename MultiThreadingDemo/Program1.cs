using System.Threading;
namespace MultiThreadingDemo
{
    class Program1
    {
        // static void Main(string[] args)
        // {
        //     // Thread t=Thread.CurrentThread;
        //     // t.Name="Main Thread";
        //     // System.Console.WriteLine($"Main Theead is working");
        //     // Thread t1 = new Thread(Function1);
        //     // Thread t2 = new Thread(Function2);
        //     // Thread t3 = new Thread(Function3);
        //     // t1.Start();
        //     // t2.Start();
        //     // t3.Start();
        //     // t1.Join();
        //     // t2.Join();
        //     // t3.Join();

           
        // }
        public static void Function1()
        {
            System.Console.WriteLine("This is fun 1");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine(2 * i);
            }
        }
        public static void Function2()
        {
            System.Console.WriteLine("This is fun 2");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine(3 * i);
            }
        }
        public static void Function3()
        {
            System.Console.WriteLine("This is fun 3");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine(4 * i);
            }
        }
    }
}