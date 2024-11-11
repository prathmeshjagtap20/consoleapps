using CustomLibrary;
namespace Extension_Method_Use
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="The Quick brown fox jumped over the : lazy dog";
            int i=s.WordCount();
            System.Console.WriteLine("word coun in string s :- "+i);
            System.Console.WriteLine(s.UpperCase());

            
            
        }
    }
}
