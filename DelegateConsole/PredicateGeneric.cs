using System;

namespace DelegateConsole
{    class PredicateGeneric
    {
        static void Main(string[] args)
        {
            Predicate<int>obj=add;
            System.Console.WriteLine(obj(23));
        }
        public static bool add(int a)
        {
            return a%2==0;
        }
    }
}