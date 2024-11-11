using System;
namespace LINQ_Demo
{
    class Student
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public  string Gender { get; set; }
        public string Branch { get; set; }

        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students=new List<Student>()
            {
                new Student{ID=1001,Name="Prathmesh",Gender="Male",Branch="CSE",Age=22},
                new Student{ID=1002,Name="Prabhav",Gender="Male",Branch="CSE",Age=24},
                new Student{ID=1003,Name="Akshay",Gender="Male",Branch="ENTC",Age=20},
                new Student{ID=1004,Name="Atharv",Gender="Male",Branch="ENTC",Age=23},
                new Student{ID=1005,Name="Prachiti",Gender="Female",Branch="ENTC",Age=23},
                new Student{ID=1006,Name="Shraddha",Gender="Female",Branch="ENTC",Age=25},
                new Student{ID=1007,Name="Dipashri",Gender="Female",Branch="AI",Age=26},
                new Student{ID=1008,Name="Sanjana",Gender="Female",Branch="CSE",Age=20},
                new Student{ID=1009,Name="om",Gender="Male",Branch="CSE",Age=22}

            };

            return students;
        }
    }
}