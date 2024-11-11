namespace Inheritance
{
 public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal BasicSalary { get; set; }

    public Employee()
    {
        Id = 1;
        Name = "Prathmesh";
        BasicSalary = 200000m;
    }

    public Employee(int id, string name, decimal basic)
    {
        Id = id;
        Name = name;
        BasicSalary = basic;
    }

    public virtual decimal GrossSalary()
    {
      return BasicSalary;
    }

    public static void Net(Employee employee)
    {
        // System.Console.WriteLine("Net Salary ="+((employee.GrossSalary())-500));
        
        System.Console.WriteLine($"Net salary = {employee.GrossSalary()-500}");
    }

    public override string ToString()
    {
        return "Employee Details :- " + Id + " " + Name + " " + BasicSalary;
    }
}
}

