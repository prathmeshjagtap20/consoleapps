using System;

namespace OperatorOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
             Rational r1=new Rational(3,4);
            Rational r2=new Rational(5,9);

            Rational r3=r1+r2;
            System.Console.WriteLine(r3);

            Rational r4=r1-r2;
            System.Console.WriteLine(r4);

            Rational r5=r1*r2;
            System.Console.WriteLine(r5);
            Rational r6= r1/r2;
            System.Console.WriteLine(r6);


         
        }
    }
}
