//wap class product with properties product id, name ,company, price, categories(enum),manufacturing date,expiring date

namespace class_obj
{

    enum categories{box,Tables,Fan};
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }

        public static int count { get; set; }

        public categories Cat { get; set; }

        public Date Man{get;set;}
        public Date Exp{get;set;}



        public Product()
        {

            Id=101;
            Name="prathmesh jagtap";
            Company="yash";
            Price=50000.00M;
            Cat=categories.Fan;
            Man=new Date(1,2,2020);
            Exp=new Date(1,3,2024);
            count++;

        }


        public Product(int id,string name, string company,decimal Price, categories cat,Date man, Date exp)
        {
            Id=id;
            Name=name;
            Company=company;
            this.Price=Price;
            this.Cat=cat;
            Man=man;
            Exp=exp;
            count++;
        }



        public static void ShowCount()
        {
            System.Console.WriteLine("Total count of employee is "+count);
        }


        public override string ToString()

        {
            return "id:- "+Id+" Name:- "+Name+" Company:- "+Company+" Categories:- "+Cat+" Manufacturing Date:-"+Man+" Expiring Date:- "+Exp;
        }






    }
}