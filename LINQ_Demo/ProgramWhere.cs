// using System;
// namespace LINQ_Demo
// {
//     class ProgramWhere
//     {
//         static void Main(string[] args)
//         {

//             //LINQ query 
//             var result=from s in Student.GetStudents() 
//             where s.Gender=="Female"
//             select s;
//             System.Console.WriteLine("---------------------list of girls---------------");
//             foreach(var s in result)
//             {
//                 System.Console.WriteLine(s.ID+" "+s.Name+" "+s.Gender);
//             }

//             System.Console.WriteLine("----------list of boys-------------------");

//             var result1=from s in Student.GetStudents() where s.Gender=="Male" select s;
//             foreach(var s in result1)
//             {
//                 System.Console.WriteLine(s.ID+" "+s.Name+" "+s.Gender);
//             }

//             System.Console.WriteLine("------------------Age greater than 22 ------------");
//             var result2=from n in Student.GetStudents() where n.Age>22 && n.Gender=="Female"  select n;
//             foreach(var s in result2)
//             {
//                  System.Console.WriteLine(s.ID+" "+s.Name+" "+s.Gender);

//             }



//             //now using lambda expression 


//             System.Console.WriteLine("--------------list of boys ----------------------");

//             var result3=Student.GetStudents().Where(s=>s.Gender=="Male");
//             foreach(var s in result3)
//             {
//                 System.Console.WriteLine(s.ID+" "+s.Name+" "+s.Gender);
//             }

//         }
//     }
// }