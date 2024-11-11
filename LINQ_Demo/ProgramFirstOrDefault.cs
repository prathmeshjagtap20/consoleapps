using System;
namespace LINQ_Demo
{
    class ProgramFirstOrDefault
    {
        static void Main(string[] args)
        {
            int[]numbers={1,2,2,3,4,5,6,6,6,75,4};
            try

            {
                var data2=numbers.FirstOrDefault(n=>n%7==0);
                System.Console.WriteLine(data2);
                // var data=numbers.First(n=>n%7==0);//it will show exception
                // System.Console.WriteLine(data);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}