namespace Abstract_demo
{
    public class Car:Vehicle,IPrintable,IDisplayble
    {
        public decimal Prize { get; set; }

        public static bool GearSystem { get; set; }=true;

        public Car(decimal Prize, string Brand, string Model, string Color, int Speed):base(Brand,Model,Color,Speed)
        {
            this.Prize=Prize; 
          
        }
        public void Display()
        {
            System.Console.WriteLine("this is the display function for the interface ");
        }
          void IPrintable.Print()
        {
            System.Console.WriteLine($"Brand : {Brand} Modle: {Model} Prize:- {Prize:c}");
            
        }
         void IDisplayble.Print()
        {
            System.Console.WriteLine("This is the print method of IDisplayble method ");
        }
        public void PrintColor()
        {
            System.Console.WriteLine($" Color of car is :- {Color}");

        }

        public override void showSpeed()
        {
            System.Console.WriteLine($"Avg speed of this {this} vehicle is {speed}");

        }
        public static void showGearSpeed()

        {

            if(GearSystem)
            {
                System.Console.WriteLine($"car has auto gear system");
            }

            else
            {
                System.Console.WriteLine("car has manual gear system ");
            }

        }


    }
}












