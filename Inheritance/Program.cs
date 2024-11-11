using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate gross salary  basice+commion*sales;
            // Manager m1 = new Manager();
            // Employee e1 = new Employee();

            // System.Console.WriteLine("Gross Salary of Employee :- " + e1.GrossSalary());
            // System.Console.WriteLine("Gross Salary of Employee :- " + m1.GrossSalary());


            // Employee.Net(e1);//early binding
            // Employee.Net(m1);// late binding/ run binding / dynamic binding



            // Circle c = new Circle();
            // Cylinder c1 = new Cylinder();
            // Circle c2 = c1;

            // c2.Area();   // in that it will print the circle area insteant of cylinder area
            // c.Area();

            // c1.Area();



            // mutilevel inheritance 
            Eagle e=new Eagle();
            Parrot p=new Parrot();
            Birds b=new Birds();
            System.Console.WriteLine(e);
            System.Console.WriteLine(p);
            System.Console.WriteLine(b);
            







        }
    }
}
