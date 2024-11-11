// using System;
// namespace MultiThreadingDemo
// {
//     class Program2
//     {
//         static void Main(string[]args)
//         {

//             Thread t1=new Thread(Program1.Function1)
//             {
//                 Name="Thread1"
//             };
//             Thread t2=new Thread(Program1.Function2)
//             {
//                 Name="Thread2"
//             };
//             Thread t3=new Thread(Program1.Function3)
//             {
//                 Name="Thread3"
//             };


//             t1.Start();
//             t2.Start();
//             t3.Start();
//             t1.Join();
//             t2.Join();
//             t3.Join();


//         }
//     }
// }