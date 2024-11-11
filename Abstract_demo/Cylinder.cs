using System;
namespace Abstract_demo
{
    public class Cylinder:Shape
    {
        public int Height{ get; set; }
        public int radius { get; set; }


        public Cylinder(int height,int radius, string color, int sides):base(color,sides)
        {
            Height=height;
            this.radius=radius;
        }

        public override void Area()
        {
           // System.Console.WriteLine($"Area of Cylinder is = {(2*Math.PI*radius*Height)(2*Math.PI*radius)}");

           // System.Console.WriteLine($"Area of Cylinder is = {(2*Math.PI*radius*Height)(2*Math.PI*radius)}");

            
    double area = 2 * Math.PI * radius * (radius + Height);
    System.Console.WriteLine($"Area of Cylinder is = {area}");
        }
    }
}