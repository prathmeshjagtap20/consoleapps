// using System;
// using CustomLibrary;

// namespace StringMethod
// {
//    static class Demo
//     {

//         static void Main(string[] args)

//         {
//             f3();
           


            
//         }
//         static void f1()
//         {
//             f2();
//         }
//         static void f2()
//         {
//             f3();
//         }
//         static void f3()
//         {
//              int a, b, c;
//             try
//             {
//                 System.Console.WriteLine("Enter a no");
//                 a = Convert.ToInt32(Console.ReadLine());
//                 System.Console.WriteLine("Enter b no ");
//                 b = Convert.ToInt32(Console.ReadLine());
//                 c = a / b;
//                 System.Console.WriteLine($"{a}/{b}={c}");

//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine("e message " + e.Message);
//                 System.Console.WriteLine("source name is :- " + e.Source);
//                 System.Console.WriteLine("Stack Trace" + e.StackTrace);
//                 System.Console.WriteLine("Help LInk" + e.HelpLink);
//                 System.Console.WriteLine("Target sits" + e.TargetSite);
//             }
//             finally
//             {
//                 System.Console.WriteLine("Code run successfully. ");
//             }
//         }

//     }
// }