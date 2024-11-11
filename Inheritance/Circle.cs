using System;

namespace Inheritance
{
    public class Circle:Point
    {
        public int raidus { get; set; }



        public Circle()

        {
            raidus=10;
           
        }


        public Circle(int r,int x,int y):base(x,y)
        {
            raidus=r;
        }

        public virtual void Area()
        {
             System.Console.WriteLine("Area of Circle is :- "+(raidus*2*Math.PI*Math.PI));
        }







        
    }
}