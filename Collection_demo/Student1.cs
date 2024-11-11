using System;
namespace Collection_demo
{
    class Student1:IComparable
    {
        public int id { get; set; }

        public string name { get; set; }

        public int marks { get; set; }

        public Student1(int id,string name, int marks)
        {
            this.id=id;
            this.name=name;
            this.marks=marks;
        }

        public override string ToString()
        {
            return $"Id :- {id} name:- {name} marks:- {marks}";
        }


        public int CompareTo(object? obj)
        {

            Student1 s1=obj as Student1;

            if(this.id<s1.id)
            {
                return -1;
            }
            else if(this.id>s1.id)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}