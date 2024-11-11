// using System;
// namespace LINQ_Demo
// {
//     class ProgramGroupBy
//     {
//         static void Main(string[] args)
//         {
//             //group by example
//             var data=Student.GetStudents().GroupBy(g=>g.Gender);
//             foreach(var gp in data)
//             {
//                 System.Console.WriteLine(gp.Key+" Count = "+gp.Count());
//                 foreach(var s in gp)
//                 {
//                     System.Console.WriteLine(s.Name);
//                 }
//             }
//         }
//     }
// }