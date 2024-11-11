// using System;

// namespace DelegateConsole
// {
//     class ActionGeneric
//     {
//         static void Main(string[] args)
//         {
//             Action<int ,int >obj=add;
//             obj+=sub;
//             obj+=mul;
//             obj+=div;
//             obj.Invoke(30,4);
//         }
//         public static void add(int a,int b)
//         {
//             System.Console.WriteLine($"The addition of  {a} and {b} = {a+b}");
//         }
//         public static void sub(int a,int b)
//         {
//             System.Console.WriteLine($"The Substraction of  {a} and {b} = {a-b}");
//         }
//         public static void mul(int a,int b)
//         {
//             System.Console.WriteLine($"The multiplication of  {a} and {b} = {a*b}");
//         }
//         public static void div(int a,int b)
//         {
//             System.Console.WriteLine($"The division of  {a} and {b} = {a/b}");
//         }
//     }
// }