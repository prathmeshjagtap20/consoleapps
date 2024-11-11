namespace Abstract_demo
{
    public class Bike:IPrintable,IDisplayble
    {
        
        public int SpeedOfBike { get; set; }


        public Bike(int SpeedOfBike)
        {
            this.SpeedOfBike=SpeedOfBike;
        }
                void IDisplayble.Print()
        {

            System.Console.WriteLine($" Speed of the Bike in Display is {SpeedOfBike}");

        }

        void IPrintable.Print()
        {
            System.Console.WriteLine($" Speed of the Bike in Printable is {SpeedOfBike}");

        }

        public void PrintColor()
        {
            System.Console.WriteLine("This is Print color");

        }

        public void Display()
        {
            System.Console.WriteLine("This is display ");

        }
    }
}