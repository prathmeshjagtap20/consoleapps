// using System;
// namespace Task_Demo
// {
//     class Program
//     {
//         static async Task Main(string[] args)
//         {

//             System.Console.WriteLine("Starting Calculation....");
//             //start a task asynchronously

//             Task<int> calculationTask=PerformCalculationAsync(10);
            
//             //you can do other work here while the calculation is running
//             System.Console.WriteLine("Doing other work while waiting for calculation to complete..");

//             //await the result of the asynchronous task
//             int result=await calculationTask;

//             System.Console.WriteLine($"Calculation result :- {result}");

//         }

//         static async Task<int>PerformCalculationAsync(int number)
//         {
//             await Task.Delay(2000);
//             return number*number
//             ;
//         }
//     }
// }