using System;
namespace IComarable_Interface
{
    internal class Employee:IComparable
    {
        public int Id { get; set; }
        public string name { get; set; }

        public decimal Salary { get; set; }

        public Employee(int Id, string name, decimal Salary)
        {
            this.Id=Id;
            this.name=name;
            this.Salary=Salary;

        }


        public override string ToString()
        {
            return Id+" "+name+"   Salary:"+Salary;
        }


        // public int CompareTo(object? obj)
        // {
        //     Employee e1= obj as Employee;
        //     if(this.Id<e1.Id)
        //     {
        //         return -1;
        //     }

        //     else if (this.Id>e1.Id)
        //     {
        //         return 1;
        //     }

        //     else
        //     {
        //         return 0;
        //     }
        // }

        public int CompareTo(object obj)
        {
            Employee e1=obj as Employee;
            return string.Compare(name,e1.name);
        }
    }
}