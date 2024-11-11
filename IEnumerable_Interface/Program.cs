using System;
using System.Collections;


namespace IEnumerable_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
             Batch b1=new Batch();
            IEnumerator er= b1.GetEnumerator();

            er.MoveNext();
            Student? s=er.Current as Student;

            System.Console.WriteLine(s);

            System.Console.WriteLine(er.Current);

            er.MoveNext();
            s=er.Current as Student;
            System.Console.WriteLine(s);

            er.MoveNext();
            s=er.Current as Student;
            System.Console.WriteLine(s);
        }
    }
}