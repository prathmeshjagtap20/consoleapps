namespace Abstract_demo
{    public abstract class Shape
    {
                public int Sides { get; set; }
                public string color { get; set; }
                public Shape(string color, int Sides)
                {
                    this.color=color;
                    this.Sides=Sides;
                }
                public abstract  void Area();    
    }
}