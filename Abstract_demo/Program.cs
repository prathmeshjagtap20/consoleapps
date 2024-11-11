using System;

namespace Abstract_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Rectangle r=new Rectangle("Green",4,100,200);
            // r.Area();
            // Circle c=new Circle(4,5,"Red");
            // c.Area();
            // Cylinder c1=new Cylinder(20,10,"black",3);
            // c1.Area();

            // Triangle t=new Triangle(10,3,"Green",30);
            // t.Area();


            // Shape[] shapes=new Shape[4];
            // shapes[0]=r;
            // shapes[1]=c;
            // shapes[2]=c1;
            // shapes[3]=t;

            // foreach(Shape shape in shapes)
            // {
            //    shape.Area();
            // }




            //   Car mycar=new Car(40000,"Hyundai","creta","White",200);
            // mycar.showSpeed();
            // Car.showGearSpeed();
            // mycar.Print();
            // mycar.PrintColor();
            // mycar.Display();





            // if two  interface has  same method name


            // IPrintable ip=mycar;
            // IDisplayble id=mycar;
            // ip.Print();
            // id.Print();



            //bike object

            // Bike obj=new Bike(20);
            // IPrintable ip=obj;
            // IDisplayble id=obj;
            // ip.Print();
            // id.Print();

            // obj.PrintColor();
            // obj.Display();



            CurrentAccount c = new CurrentAccount(2.5f, 32020m, 1, new Customer(1, "Prathmesh", "Jagtap", "pj@gmail.com", "Solapur Maharastra", 99999999, new Date(14, 03, 2002)));

            SavingAccount s = new SavingAccount(4.5f, 23000m, 2, new Customer(2, "Rohan", "Shetti", "Rohan@gmail.com", "Solapur Maharastra", 9292949392, new Date(14, 03, 2002)));
            System.Console.WriteLine(c);
            c.ShowBalance();

            System.Console.WriteLine(s);
            s.ShowBalance();


            Demo d = new Demo();


           

        }
    }
}
