// using System;
// using System.Collections;
// using System.Runtime.Intrinsics.Arm;

// namespace StringMethod
// {
//     internal class Program 
//     {
//         static void Main(string[] args)
//         {

          








//             //System.Console.WriteLine("hello world.");
//             // string s1 = "hello";
//             // string s2 = "pj";

//             //string.Compare():-  it will compare the string using lexicographically.Means alphabetically of their character. and it will return the 0,1,-1 value.
//             // System.Console.WriteLine(string.Compare(s1,s2));

//             //CompareTo():- it is same as the compare() method.but Compare is a static method, while CompareTo is an instance method
//             //  System.Console.WriteLine(s1.CompareTo(s2));

//             //Copy():- It is used to create a new instance of the string
//             // string s3=string.Copy(s1);  
//             // System.Console.WriteLine(s3);

//             //CopyTo():- CopyTo(int index, char[] ch, int start, int end)  In that 
//             //index:- is nothing but the from which position you want to start the copy
//             //start:- give the starting position
//             //end:- give the ending position.




//             // string s4="hello you are good to see you ";

//             //             char[] ch=new char[15];
//             //             s4.CopyTo(6,ch,0,5);
//             //             System.Console.WriteLine(ch);


//             //EndsWith():- it will return the boolean value based on the string is present or not.
//             //     string s1 = "Hello";    
//             //  string s2 = "llo";  
//             //  string s3 = "C#";  
//             //  Console.WriteLine(s1.EndsWith(s2));  
//             //  Console.WriteLine(s1.EndsWith(s3));  

//             //Equals():- it will return the boolean value if based on the string is equal or not.

//             //   string s1 = "Hello";    
//             //      string s2 = "Hello";  
//             //      string s3 = "Bye";  
//             //      Console.WriteLine(s1.Equals(s2));  
//             //      Console.WriteLine(s1.Equals(s3));  

//             //GetType():- it is used to get the type of current instance.
//             //            string s1 = "Hello C#";  
//             //   Console.WriteLine(s1.GetType());  //it will print the System.String.


//             //IndexOf:- in that it will give the index value
//             //          string s1 = "Hello C#";  
//             //   int index = s1.IndexOf('e');  
//             //   Console.WriteLine(index);  


//             //Insert():- it will insert the string based on the position.
//             // string s1 = "Hello C#";
//             // string s2 = s1.Insert(5, "-");
//             // Console.WriteLine(s2);

//             //LastIndexOf():- it will give the index of the last index.
//             //      string s1 = "Hello C#";  
//             //    int index = s1.LastIndexOf('l');  
//             //    Console.WriteLine(index);  


//             //Remove():- it will remove the string based on the value if value is 4 then it will remove the 4 elements.

//             // string s1 = "Hello C#";  
//             //            string s2 = s1.Remove(4);  
//             //            Console.WriteLine(s2); 

//             //Replace():- it will replace the from one char to another char

//             // string s1 = "Hello F#";
//             // string s2 = s1.Replace('F', 'C');
//             // Console.WriteLine(s2);

//             //Splite():- it will splite the string into substring

//         //      string s1 = "Hello C Sharp";  
//         //    string[] s2 = s1.Split(' ');  
//         //    foreach (string s3 in s2)  
//         //    {  
//         //     Console.WriteLine(s3);  
//         //    }  

//         //StartsWith():- it will return boolean value
//         string s1="pj is good man";

//         // System.Console.WriteLine(s1.StartsWith("p"));

//         //SubString(int value):- it will print the string from the vlaue


// //System.Console.WriteLine(s1.Substring(4));

// //ToCharArray():- it will convert the string to char array
// //ToLower():- it will convert to Lower case.

// //ToString():- it will convert the int to string and char to string
// //ToUpper():- it will convert the string to upper case.


// //Trim():- it is used to remove all leadin and last white space from the string.

// string s2="   pj    is good   man    ";
// System.Console.WriteLine(s2.Trim());// it will remove start and end space  from the strin .

// System.Console.WriteLine(s2.TrimEnd(' '));// it will remove the end space or char from the string
// System.Console.WriteLine(s2.TrimStart(' '));// it wil remove the start space or char from the string.






//         }

//         private static void f3()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }