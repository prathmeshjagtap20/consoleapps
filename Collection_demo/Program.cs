// using System;
// using System.Collections;

// namespace Collection_demo
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {




//             //boxing process of upgrading value to object type happening when Add() method.

//             // unboxing process happens (downcasting) object type converted to its original value.


//             // ArrayList a = new ArrayList();
//             // a.Add(3);
//             // a.Add("prathmsh");
//             // a.Add(DateTime.Now);
//             // a.Add(true);
//             // a.Add('p');
//             // a.Add(3.53333);
//             // a.Add(5.39m);
//             // Student s = new Student(101, "Prathmesh");
//             // a.Add(s);
//             // System.Console.WriteLine("ArrayList has " + a.Count + " Items");   // finding the size of the arraylist
//             // foreach (var i in a)
//             // {
//             //     System.Console.WriteLine(i);
//             // }



//             // 2. Stack    ------------------- // LIFO last in first out.
//             // Stack mystack = new Stack();
//             // mystack.Push(10);
//             // mystack.Push("Prathmesh");
//             // mystack.Push(3.43);
//             // mystack.Push(DateTime.Now);
//             // mystack.Push(true);

//             // System.Console.WriteLine("Stack has "+mystack.Count+" items");// finding the size of the stack

//             // try
//             // {
//             //     System.Console.WriteLine(mystack.Peek());
//             //     System.Console.WriteLine(mystack.Pop());
//             //     System.Console.WriteLine(mystack.Pop());
//             //     System.Console.WriteLine(mystack.Pop());
//             //     System.Console.WriteLine(mystack.Pop());
//             //     System.Console.WriteLine(mystack.Pop());
//             //     System.Console.WriteLine(mystack.Pop());

//             // }

//             // catch (Exception e)
//             // {
//             //     System.Console.WriteLine(e.Message);
//             // }




//             // 3.    Queue -----  Non generic queue FIFO first in first out.


//             // Queue myqueue = new Queue();

//             // myqueue.Enqueue(0);
//             // myqueue.Enqueue("Prathemsh");
//             // myqueue.Enqueue(393.00m);
//             // myqueue.Enqueue(true);


//             // System.Console.WriteLine("count of QUeue is " + myqueue.Count);
//             // System.Console.WriteLine(myqueue.Dequeue());

//             //  List_demo l = new List_demo();

//             //4 Generic List
//             //  List<string> fruits = new List<string>();

//             //     fruits.Add("mango");
//             //     fruits.Add("banana");
//             //     fruits.Add("Apple");
//             //     fruits.Add("Papai");
//             //     fruits.Remove("mango");  // It is for removing the value from the list

//             //     foreach (var v in fruits)
//             //     {
//             //         System.Console.WriteLine(v);
//             //     }

//             //     fruits.Sort();    // sort in the list. 

//             //     System.Console.WriteLine("\n After sorting ");

//             //      foreach (var v in fruits)
//             //     {
//             //         System.Console.WriteLine(v);
//             //     }

//             //     System.Console.WriteLine("After removing mango ---------");

//             //     for(var i=0;i<fruits.Count;i++)
//             //     {
//             //         System.Console.WriteLine(fruits[i]);
//             //     }



//             // List<Student1> studen=new List<Student1>();
//             // studen.Add(new Student1(1,"pj",30));
//             // studen.Add(new Student1(3,"vk",40));
//             // studen.Add(new Student1(2,"Dj",50));
//             // studen.Add(new Student1(4,"Rk",60));
//             // System.Console.WriteLine("No of student is Lis is :- "+studen.Count);


//             // foreach(var a in studen)
//             // {
//             //     System.Console.WriteLine(a);
//             // }


//             // studen.Sort();// In the collection we can use the obj.Sort();



//             // foreach(var a in studen)
//             // {
//             //     System.Console.WriteLine(a);
//             // }




//             // 5. Generic Stack

//             // System.Console.WriteLine("Stack");
//             // System.Console.WriteLine();



//             // Stack<string> st = new Stack<string>();
//             // st.Push("pj");
//             // st.Push("vk");
//             // st.Push("Dk");

//             // System.Console.WriteLine(st.Pop());
//             // System.Console.WriteLine();
//             // System.Console.WriteLine("Queue");


//             // //6. Generic Queue


//             // Queue<string> qu = new Queue<string>();

//             // qu.Enqueue("Vishal");
//             // qu.Enqueue("Akshay");
//             // qu.Enqueue("Prathmesh");
//             // qu.Enqueue("Atharv");
//             // qu.Enqueue("Yuvaraj");

//             // System.Console.WriteLine(qu.Dequeue());

//             // System.Console.WriteLine(qu.Dequeue());

//             // System.Console.WriteLine(qu.Dequeue());

//             // System.Console.WriteLine(qu.Dequeue());

//             // System.Console.WriteLine("No of Count is Queue is :- "+qu.Count);

//             // System.Console.WriteLine();



//             //6. non generic HashTable

//             //  HashTable h1=new HashTable();



//             //  Hashtable h1 = new Hashtable();
//             //     h1.Add(1, "Welcome");
//             //     h1.Add("pj", 2);
//             //     h1.Add("vk", 5);

//             //     System.Console.WriteLine("Key and value pair from h1:");

//             //     foreach (DictionaryEntry dic in h1)
//             //     {
//             //         System.Console.WriteLine("Key is: " + dic.Key + ", Value is: " + dic.Value);
//             //     }



//             // Hashtable h2=new Hashtable(){
//             //     {1,"hello"},
//             //     {2,243},
//             //     {3,422.3},
//             //     {4,null}

//             // };


//             // foreach (var item in h2.Keys)
//             // {
//             //     System.Console.WriteLine("{0} and {1}",item,h2[item]);//h2[item] with this it will print the value pair

//             // }
















//         }
//     }
// }
