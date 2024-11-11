using System;
using System.Reflection;

namespace ReflectionDemo
{
    class StudentResult
    {
        static void Main(string[] args)
        {
            string[] studentNames = { "pj", "vikas", "rohan", "vaibhav", "rk" };

            int[] marks = { 50, 30, 45, 60, 20 };

            // Iterate over the students and call the GetResult method using reflection
            for (int i = 0; i < studentNames.Length; i++)
            {
                // Create a new Student instance
                Student student = new Student(studentNames[i]);

                // Get the type of the Student class
                Type studentType = student.GetType();

                // Get the GetResult method
                MethodInfo getResultMethod = studentType.GetMethod("GetResult");

                // Invoke the GetResult method with the marks as a parameter
                string result="";

                foreach(string parameter in studentNames)
                {
                   result=(string) getResultMethod.Invoke(student, new object[] { marks[i] });
                   
                }
                System.Console.WriteLine(result);
               // string result = (string)getResultMethod.Invoke(student, new object[] { marks[i] });

                // Print the result
               // Console.WriteLine(result);
            }

        }
    }
}



