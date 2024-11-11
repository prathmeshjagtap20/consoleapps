using System;
namespace Indexer_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch=new Batch();
            int n=101;
            try
            {
                System.Console.WriteLine(batch[104]);
                System.Console.WriteLine("Id of prathmeh is "+batch["prathmesh"]);
                batch[105]="pj";
                System.Console.WriteLine("Id 105 name:- "+batch[105]);
                batch["prathmesh"]=222;
                System.Console.WriteLine("Id of Prathmesh is :- "+ batch["prathmesh"]);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
