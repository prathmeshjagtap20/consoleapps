using System;

namespace Collection_demo
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }


        public Student(int id, string name)
        {
            this.id=id;
            this.name=name;
        }

        public override string ToString()
        {
            return $"{id } {name}";
        }
    }
}