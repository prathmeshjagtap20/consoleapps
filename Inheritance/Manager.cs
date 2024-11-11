namespace Inheritance
{
    public class Manager : Employee
    {

        public decimal Commission { get; set; }

        public int Sales { get; set; }



        public Manager()
        {
            Commission = 199;
            Sales = 10;
        }


        public Manager(decimal commission, int sales, int id, string name, decimal BasicSalary) : base(id, name, BasicSalary)
        {

            Commission = commission;
            Sales = sales;

        }

        public override string ToString()
        {
            return base.ToString() + " Commision: " + Commission + " Sale Done:- " + Sales;
        }



       


        public override decimal GrossSalary()
        {



        return base.BasicSalary + Commission * Sales;

        }



    }
}