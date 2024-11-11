namespace Inheritance
{
    public class Eagle:Parrot
{
    public int height { get; set; }


    public Eagle()
    {

        height=20;

    }


    public Eagle(int h,string eye, int weg, string col):base(eye,weg,col)
    {
        height=h;
    }

    public override string ToString()
    {
        return "Eagle Information :- Height="+height;
    }
}
}