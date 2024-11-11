

namespace class_obj
{
    class Student
    {


         public int Id { get; set; }

        public string First_name { get; set; }

        public string Last_name  { get; set; }

        public int Marks { get; set; }

        //default construtor

        public Student()
        {
            Id=101;
            First_name="Prathmesh";
            Last_name="Jagtap";
            Marks=8;
        }

        public Student(int id, string first_name, string last_name,int marks)
        {
           Id=id;
           First_name=first_name;
           Last_name=last_name;
           Marks=marks;

            // System.Console.WriteLine("My id is "+id);
            
            // System.Console.WriteLine("My First name  is "+first_name);
            
            // System.Console.WriteLine("My Laat name is "+last_name);
            
            // System.Console.WriteLine("My Marks is "+marks);
        }



        public override string ToString()
        {
            return "id:- "+Id+" first name :- "+First_name+" Last name:- "+Last_name+" Marks:- "+Marks;
        }





    }
}