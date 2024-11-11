using System.Threading;
namespace MultiThreadingDemo
{
    class Numbers
    {
        // static void Main(string[] args)
        // {
        //     Numbers numbers = new Numbers();
        //     Thread T = new Thread(numbers.Function1);
        //     T.Start();
        //     T.Join();
        // }

        public void Function1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine(i);
            }
        }

         public void Function2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine(i*2);
            }
        }


    }
}