using System.Reflection;
using System.Threading;
namespace MultiThreadingDemo
{
    class ParameterDelegate
    {
        static void Main(string[] args)

        {

            ParameterizedThreadStart obj = new ParameterizedThreadStart(DisplayNumbers);
            obj.Invoke(10);
            Thread t1 = new Thread(obj);
            t1.Start();
            t1.Join();



        }

        static void DisplayNumbers(object n)
        {

            try
            {
                for (int i = 1; i < (int)n; i++)
                {

                    Thread.Sleep(100);
                    System.Console.WriteLine(i);
                }

            }

            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}