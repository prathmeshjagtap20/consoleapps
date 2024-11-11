// using System;
// using System.Reflection;
// namespace ReflectionDemo
// {
//     class ProgramFieldInfo
//     {
//         static void Main(string[] args)
//         {
//             Type p = typeof(Person);
//             //accessing a field using reflection

//             FieldInfo nameField = p.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
//             System.Console.WriteLine($"Field name :- {nameField.Name}");

//             //accessing a private property using reflection.

//             PropertyInfo ageProperty=p.GetProperty("age",BindingFlags.NonPublic | BindingFlags.Instance);
//             System.Console.WriteLine("Property name :- "+ageProperty.Name);

//             //accessing a private method using reflection.
//             MethodInfo sayhelloMethod = p.GetMethod("SayHello", BindingFlags.NonPublic | BindingFlags.Instance);
//             System.Console.WriteLine("Method name :-" + sayhelloMethod.Name);
//         }
//     }
// }