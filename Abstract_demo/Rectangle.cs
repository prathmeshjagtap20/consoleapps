namespace Abstract_demo
{
    public class Rectangle:Shape

    {
        public int len { get; set; }

        public int bre { get; set; }


        public Rectangle(string color,int Sides,int l,int b):base(color,Sides)
        {
            len=l;
            bre=b;
        }


        public override void Area()
        {
            System.Console.WriteLine($"Area of Rectangle = { len*bre}");
        }
    }
}