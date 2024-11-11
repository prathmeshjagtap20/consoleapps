using System;
using MyLib1;
namespace class_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date today = new Date(3, 45, 1434);
            // Date today1 = new Date();


            // Student obj=new Student(101,"pj","Jagtap",500);
            // Student obj1=new Student();
            // System.Console.WriteLine(obj);   // it will print the Tostring methods .



            // Employee e = new Employee();
            // Employee e2 = new Employee(101, "prathmesh", "Jagtap", 500000.00M, Department.IT, new Date(1, 2, 2000));
            // System.Console.WriteLine(e);


            Product p = new Product(101, "prathmesh", "Yash", 500000.00M, categories.Fan, new Date(1, 2, 2020), new Date(1, 2, 2024));


            Product p1 = new Product();
            // System.Console.WriteLine(p1.GetType());   //it give the folder name and class name.
            // System.Console.WriteLine(p1.GetHashCode());  // it will give the hash value.


            // System.Console.WriteLine(p1.Equals(p));  // it check the properties of the objects.


            // System.Console.WriteLine(Product.count);      // it is static variable.

            // Product.ShowCount();       // it is static method.


            // System.Console.WriteLine(p);
            // System.Console.WriteLine(p1);


            // Product[] products = new Product[5];

            // products[0] = new Product(101, "soham", "Yash", 4000, categories.Tables, new Date(1, 1, 2000), new Date(1, 1, 2024));
            // products[1] = new Product(102, "prathm", "Yash", 5000, categories.Tables, new Date(1, 1, 2000), new Date(1, 1, 2024));
            // products[2] = new Product(103, "Om", "Yash", 60000, categories.Tables, new Date(1, 1, 2000), new Date(1, 1, 2024));
            // products[3] = new Product(104, "Vikas", "Yash", 70000, categories.Tables, new Date(1, 1, 2000), new Date(1, 1, 2024));
            // products[4] = new Product(105, "Akshay", "Yash", 60000, categories.Tables, new Date(1, 1, 2000), new Date(1, 1, 2024));


            // foreach(var product in products)
            // {
            //     System.Console.WriteLine(product);
            // }





            //MyMath.Add();          // static method from the static class

            //System.Console.WriteLine(MyMath.a);   // access the static variable from the use of class name.





            //Object class is standard class in .net








            MyMath m1 = new MyMath();

            m1.Add(20, 40);
            m1.Sub(50, 40);
            m1.Mult(120, 40);
            m1.Div(220, 40);









        }
    }
}
