// using System.Threading;
// namespace MultiThreadingDemo
// {   class Program
//     { static void Main(string[]args)
//         {
//             Thread t=Thread.CurrentThread;
//             t.Name="Main Thread";
//             System.Console.WriteLine($"Main thread is working ");
//             Thread t1=new Thread(DisplayNumbers);
//             t1.Name="Thread1";
//             t1.Start();
//             Console.Read();
//         }
//         public static void DisplayNumbers()
//         {
//             for(int i=1;i<=10;i++)
//             {
//                 Thread.Sleep(1000);
//                 System.Console.WriteLine($" {i}");
//             }
//         }
//     }
// }