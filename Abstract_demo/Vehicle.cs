namespace Abstract_demo
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int speed{ get; set; }



        public Vehicle(string Brand, string Model, string Color, int speed)
        {
            this.Brand=Brand;
            this.Model=Model;
            this.Color=Color;
            this.speed=speed;
        }


        public abstract void showSpeed();
    }
}