// using System;

// namespace DelegateConsole
// {
//     //1. delcare delegate
//     public delegate string MyDelegate(string s1, string s2);

//     public delegate int MySumDel(int a,int b);
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             //2 create instance or object of the delegate.

//             MyDelegate obj = new MyDelegate(GetFullname);
//             string ans = obj("prathmesh", "Jagtap");

//             System.Console.WriteLine("Called function vie delegate :- " + ans);



//             MySumDel obj1=new MySumDel(GetSum);
//             int ans1=obj1(1,2);
//             System.Console.WriteLine("The addition of no1 and no2 is "+ans1);
          

//         }
//         public static string GetFullname(string fname, string lname)
//         {
//             return fname + " " + lname;
//         }


//         public static int GetSum(int a,int b)
//         {
//             return a+b;
//         }




    
//     }
// }