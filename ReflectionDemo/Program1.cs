// using System;
// using System.Diagnostics;
// using System.Reflection;

// namespace ReflectionDemo
// {
//     static class MyClass
//     {
//         public static void Inform(string parameter)
//         {
//             System.Console.WriteLine("Inforam parameter "+parameter);
//         }
//     }
//     class Program1
//     {
//         static void Main(string[] args)
//         {
//             //call it with each of these parameters.
//             string[] parameters={"raj","test","Pratik"};

//             //get methodInfo

//             Type type=typeof(MyClass);

//             MethodInfo info=type.GetMethod("Inform");

//             foreach(string parameter in parameters)
//             {
//                  info.Invoke(null,new Object[] {parameter});
//              }
//         }
//     }
// }

// //write a class student in inside that write a method getresult by passing integer as a parameter and show the result of pass and fail call this method using reflection for five studetn.