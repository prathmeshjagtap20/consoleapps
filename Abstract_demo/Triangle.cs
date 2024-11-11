namespace Abstract_demo
{ public class Triangle:Shape
    {
        public int length { get; set; }
        public int height { get; set; }
        public Triangle(int length,int height, string color, int sides):base(color,sides)
        {
            this.length=length;
            this.height=height;
        }
        public override void Area()
        {
            double d=length*height;
            System.Console.WriteLine($" Area of Triangle :- {d}");
        }
    }
}