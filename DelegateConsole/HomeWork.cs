// using System;

// namespace DelegateConsole
// {

//     public delegate void MyDelegates(string s);
//     class HomeWork
//     {
//         static void Main(string[] args)
//         {

//             MyDelegates obj=new MyDelegates(UpperCase);
//             obj+=LowerCase;
//             obj+=SentenceCase;
//             obj.Invoke("prathmesh jagtap is good boy");

//         }



//         public static void UpperCase(string a)
//         {
//             System.Console.WriteLine("In Upper case :-" + a.ToUpper());
//         }

//         public static void LowerCase(string a)
//         {
//             System.Console.WriteLine("In Lower case :- " + a.ToLower());
//         }

//        public static void SentenceCase(string a)
//        {
//         string []s=a.Split(" ");
//         for(int i=0;i<s.Length;i++)
//         {
//             s[i]=s[i].Substring(0,1).ToUpper()+s[i].Substring(1);
//         }

//         a=string.Join(" ",s);
//         System.Console.WriteLine("After sentence case is :- "+a);
//        }




//     }
// }