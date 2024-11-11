using System;
using System.Reflection;

// Define the Student class

namespace ReflectionDemo
{
    public class Student
    {
        public string Name { get; set; }       
        public Student(string name)
        {
            Name = name;
        }

        public string GetResult(int marks)
        {
            if (marks >= 40)
            {
                return $"{Name} = {marks} marks. Pass";
            }
            else
            {
                return $"{Name} = {marks} marks. Fail";
            }
        }
    }
}