using System;
namespace ReflectionDemo
{
    class Person
    {
        private string name;
        private int age { get; set; }
        private void SayHello()
        {
            System.Console.WriteLine("Hello ! PJ");
        }
    }
}