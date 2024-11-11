// using System.Runtime.ConstrainedExecution;

// namespace DelegateConsole
// {
//     //delegate used for event handlings.
//     public delegate void MyMathDel(int a, int b);
//     class Program1
//     {
//         static void Main(string[] args)
//         {
//             MyMathDel obj = new MyMathDel(sum);
//             obj += sub;           //
//             obj += Mul;
//             obj += Div;

//                    // it is used to delegate fire.

//             obj.Invoke(30, 2);

//         }
//         public static void sum(int a, int b)
//         {
//             System.Console.WriteLine($"{a} + {b} = {a + b}");
//         }
//         public static void sub(int a, int b)
//         {
//             System.Console.WriteLine($"{a} - {b} = {a - b}");
//         }
//         public static void Mul(int a, int b)
//         {
//             System.Console.WriteLine($"{a} * {b} = {a * b}");
//         }
//         public static void Div(int a, int b)
//         {
//             System.Console.WriteLine($"{a} / {b} = {a / b}");
//         }


      

//     }
// }