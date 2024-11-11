using System;
using System.Reflection;

namespace Reflection_CreateInstance_Runtime
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(TestClass);

            MethodInfo[] m = t.GetMethods();

            foreach (MethodInfo method in m)//methods is a name of array MethodInfo
            {
                System.Console.WriteLine(method.Name);
            }

            ConstructorInfo ctor = t.GetConstructor(System.Type.EmptyTypes);
            MethodInfo m1 = t.GetMethod("TestMethod");
            object obj = ctor.Invoke(null);

            System.Console.WriteLine("ans1= " + m1.Invoke(obj, new object[] { 10 }));

            //call add method run time
            object[] parameters = { 29, 30 };//two parameters to pass as an array
            MethodInfo m2 = t.GetMethod("Add");
            System.Console.WriteLine("ans2 :- " + m2.Invoke(obj, parameters));
        }
    }
}
