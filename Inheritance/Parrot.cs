namespace Inheritance
{
    public class Parrot:Birds
    {
        public string eyes { get; set; }



        public Parrot()
        {
            eyes="black";
        }


        public Parrot(string eye, int weg, string col):base( weg,col)
        {
            eyes=eye;
        }


        public override string ToString()
        {
            return "Parrot Details:- eyes"+eyes;
        }
    }
}