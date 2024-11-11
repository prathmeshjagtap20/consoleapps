using System;
namespace Partial_class
{
    partial class MyForm
    {
        public partial void Greet(string s)
        {
            System.Console.WriteLine($"{name} {Description} for this great Event of ........ {s}");
        }

       
    }
}