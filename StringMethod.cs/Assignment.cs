// using System;
// namespace StringMethod
// {
//     class Assignment
//     {
//         static void Main(string[] args)

//         {
//             System.Console.WriteLine("Enter the string :- ");
//             string s1 = Console.ReadLine();

//             string[] str = s1.Split(" ");

//           //  System.Console.WriteLine(str[2]);

//             // foreach(string s in str)
//             // {
//             //     System.Console.WriteLine(s);
//             // }

//             for (int i = 0; i < str.Length; i++)
//             {
                
//                     str[i] = str[i].Substring(0, 1).ToUpper() + str[i].Substring(1);
                
//             }

//             string ans = string.Join(" ", str);
//             System.Console.WriteLine(ans);
//         }

//     }
// }