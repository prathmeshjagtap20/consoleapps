// using System.Threading;

// namespace Multithreading_Synchronization
// {
//     class _BankAccount
//     {
//         private static decimal _balance;

//         private static readonly object _lockobject = new object();
//         public _BankAccount(decimal initialBalance)
//         {
//             _balance = initialBalance;
//         }

//         // Deposit money into the account

//         public void Deposit(object amount)
//         {
//             lock (_lockobject)
//             {
//                 Console.WriteLine($"Depositing {amount:C}");
//                 _balance += (decimal)amount;

//             }

//             // Console.WriteLine($"New Balance: {_balance:C}");
//         }
//         // Withdraw money from the account

//         public void Withdraw(object amount)
//         {
//             if (_balance >= (decimal)amount)
//             {
//                 Console.WriteLine($"Withdrawing {amount:C}");
//                 _balance -= (decimal)amount;
//                 // Console.WriteLine($"New balance: {_balance:C}");
//             }
//             else
//             {
//                 Console.WriteLine("Insufficient Balance!");
//             }
//         }

//         public decimal GetBalance()
//         {
//             return _balance;
//         }
//         static void Main(string[] args)
//         {

//             _BankAccount account = new _BankAccount(1000.00m);
//             // ParameterizedThreadStart obj=new ParameterizedThreadStart(account.Deposit);

//             Thread depositThread = new Thread(() =>
//             {
//                 for (int i = 0; i < 10; i++)
//                 {
//                     account.Deposit(100m);
//                     Thread.Sleep(100);
//                 }
//             });
//             Thread withdrawThread = new Thread(() =>
//             {
//                 for (int i = 0; i < 10; i++)
//                 {
//                     account.Withdraw(50m);
//                     Thread.Sleep(50);
//                 }
//             });

//             depositThread.Start();
//             withdrawThread.Start();

//             depositThread.Join();
//             withdrawThread.Join();

//             System.Console.WriteLine("Final amount " + account.GetBalance());

//         }


//     }
// }