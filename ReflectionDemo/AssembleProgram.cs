// using System;
// using System.Reflection;

// namespace ReflectionDemo
// {
//     class AssembleProgram
//     {
//         static void Main(string[] args)
//         {
//             MethodInfo?[] methods;

//             Type[] types=new Type[2];

//             try
//             {
//                 Assembly asm=Assembly.LoadFrom(@"D:\consoleapps\MyLibrary\bin\Debug\net8.0\MyLibrary.dll");

//                 types =asm.GetTypes();

//                 foreach(Type t in types)
//                 {
//                     System.Console.WriteLine("class Name "+t.FullName);


//                    foreach(MethodInfo m in t.GetMethods())
//                    {
//                     System.Console.WriteLine("Mthod name :- "+m.Name);
//                    }
//                 }
//             }
//             catch(Exception e)
//             {
//                 System.Console.WriteLine(e);
//             }
//         }
//     }
// }