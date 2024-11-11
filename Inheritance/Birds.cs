namespace Inheritance
{

    //create a birt class with weight and two color, and write a voice method
    public class Birds
    {
        public int weight { get; set; }
        public string color { get; set; }


        public Birds()
        {
            weight=30;
            color="Red";
        }


        public  virtual void Voice()
        {
            System.Console.WriteLine("This is birds voice...");
        }



        public Birds(int weg, string col)
        {
            weight=weg;
            color=col;

        }

        public override string ToString()
        {

            return "Birds Details :- weight "+weight+" Color "+color;
            
        }


       





    }
}