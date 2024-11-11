using System;
namespace IEnumerable_Interface
{
    class Student
    {

        
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"id :- {id}, Name:- {name}";
        }
    }
}