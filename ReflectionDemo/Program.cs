// using System;
// using System.Reflection;
// using System.Linq;

// namespace ReflectionDemo

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //get typeof enumerable and load it to type variable t
//             // Type t=typeof(double);    //output :- name :-Double  NameSpace :- System  Base type :- System.ValueType

//             //  Type t=typeof(int); //output :- name :-Int32          NameSpace :- System          Base type :- System.ValueType

//             Type t = typeof(Person);// output :- name :-Person  NameSpace :- ReflectionDemo   Base type :- System.Object

//             //the type class properties return information about the enumerable type

//             System.Console.WriteLine("name :-" + t.Name);
//             System.Console.WriteLine("NameSpace :- " + t.Namespace);
//             System.Console.WriteLine("Base type :- " + t.BaseType);
//         }
//     }
// }