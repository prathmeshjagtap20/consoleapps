using System;
namespace Inheritance
{


    public class Cylinder:Circle

    {

        public int Height { get; set; }


        public Cylinder()
        {
            Height=20;
        }


        public Cylinder(int h, int r, int x,int y ):base(r,x,y)
        {
            Height=h;
        }


         public new void Area()
        {
             System.Console.WriteLine("Area of Cylinder is :- "+(2*Math.PI*raidus*(Height+ raidus)));
        }


    }

}