namespace Inheritance
{
    public class Point:Weight
    {
        public int x { get; set; }
        public int y { get; set; }


        public Point()
        {
            x=10;
            y=20;
        }

        public Point(int x,int y)
        {
            this.x=x;
            this.y=y;
        }
    }
}