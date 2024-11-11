// using System.Threading;
// namespace Multithreading_Synchronization
// {
//     class Program
//     {
//         private static int counter = 0;
//         static void Main(string[] args)
//         {
//             // Thread[] threads = new Thread[10];
//             // ParameterizedThreadStart obj = new ParameterizedThreadStart(IncrementCounter);
//             // for (int i = 0; i < threads.Length; i++)
//             // {
//             //     threads[i] = new Thread(obj);
//             //     threads[i].Start(5);
//             // }
//             // foreach (Thread t in threads)
//             // {
//             //     t.Join();
//             // }
//             // Console.WriteLine($"Final counter value: {counter}");



// //-----------------------------------------------BankAccount--------------------------------------------------

//             BankAccount account=new BankAccount(1000.00m);
//             ParameterizedThreadStart obj=new ParameterizedThreadStart(account.Deposit);
//             Thread DepositThread=new Thread(obj);
//             DepositThread.Start(700.00m);
// DepositThread.Join();
//             Thread withdrawThread=new Thread(account.Withdraw);
//             withdrawThread.Start(300.00m);
//             DepositThread.Join();
//        //     account.GetBalance();

//             System.Console.WriteLine("Final balance :"+account.GetBalance());



//         }

//         private static void IncrementCounter(object? value)
//         {
//             for (int i = 0; i < 1000; i++)
//             {
//                 // Safety increment counter by 1
//                 Interlocked.Add(ref counter, (int)value);
//             }

//         }
//     }
// }
