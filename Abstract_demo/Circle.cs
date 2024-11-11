using System;
namespace Abstract_demo
{
    public class Circle:Shape
    {
        public int radius { get; set; }



        public Circle(int r,int sides,string color):base(color,sides)

        {
            radius=r;

        }

        public override void Area()
        {
            System.Console.WriteLine($"Area of Circle is = {Math.PI*radius*radius}");
        }









    }
}