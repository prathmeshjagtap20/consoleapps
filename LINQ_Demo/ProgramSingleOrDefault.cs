// using System;
// namespace LINQ_Demo
// {
//     class ProgramSingleOrDefault
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = { 1, 2, 3, 4, 2, 32, 44, 5 };
//             try
//             {

//                 // difference between single or singleOrDefault:-

//                 //if data is not in the database or array then single will throw error :- InvalidOperationException "contains no matching record"
//                 //while singleOrDefault return the 0 value it will not throw an error 

//                 var data1=numbers.SingleOrDefault(n=>n>100);
                
//                 System.Console.WriteLine(data1);
//                 // var data = numbers.Single(n => n > 100);
//                 // System.Console.WriteLine(data);
//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }
//         }
//     }
// }