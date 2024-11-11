// using System.Threading;
// namespace MultiThreadingDemo
// {
//     class Delegate
//     {
//         static void Main(string[]args)
//         {
//             Numbers obj=new Numbers();
//             ThreadStart delobj = new ThreadStart(obj.Function1);
           
//             Thread t1=new Thread(delobj);
//             t1.Start();
//             t1.Join();
//         }
//     }
// }