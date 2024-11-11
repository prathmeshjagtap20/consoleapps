namespace class_obj
{
    enum Department{IT, HR, Accounts,Electrical, Civil, Computer_science};
    class Employee
    {
        public int Id { get; set; }

        public string First_name { get; set; }

        public string Last_name { get; set; }

        public decimal salary { get; set; }

        public Department dept { get; set; }

        public Date Doj { get; set; }



        public Employee()
        {
            Id = 101;
            First_name = "Prathmesh";
            Last_name = "Jagtap";
            salary = 5000000.00M;
            dept=Department.Computer_science;
            Doj=new Date();
        }


        public Employee(int id, string first_name, string last_name, decimal salary, Department dept, Date Doj)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            this.salary = salary;
            this.dept=dept;
            this.Doj=Doj;
        }


        public override string ToString()
        {
            return "id:- "+Id+" First name:- "+First_name+" Last name:- "+Last_name+" Salary:- "+salary+ " Department:- "+dept+" Date of Joining is:- "+Doj;
        }
    }
}
