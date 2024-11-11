using System;

namespace AttributeClass_Demo
{
    [MyCustom("pj", 1.0)]
    class Student
    {
        int id;
        string name;
        char grade;
        public Student()
        {
            id = 1;
            name = "prathemsh";
            grade = 'A';
        }

        public Student(int i, string s, char c)
        {
            id = i;
            name = s;
            grade = c;
        }

        public void ShowResult()
        {
            if (this.grade == 'A')
            {
                Console.WriteLine("Student is passed with first class");
            }
            else if (this.grade == 'B')
            {
                Console.WriteLine("Student is passed with second class");
            }
            else if (this.grade == 'C')
            {
                Console.WriteLine("Student is passsed with pass class");
            }
            else if (this.grade == 'F')
            {
                Console.WriteLine("Student is fail");
            }
            else
            {
                Console.WriteLine("Please enter valid grade...");
            }
        }
    }
}