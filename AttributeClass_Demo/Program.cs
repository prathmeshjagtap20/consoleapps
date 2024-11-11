using System;
using System.Reflection;
using System.Security.Cryptography;

namespace AttributeClass_Demo
{
    class Program
    {
        static void Main()
        {
            Student s=new Student();

            Type t=s.GetType();//t=student
            System.Console.WriteLine("name of class from obj ="+s.GetType());
            System.Console.WriteLine("Name of class from boj ="+t);


            var classAttribute=(MyCustomAttribute)Attribute.GetCustomAttribute(t,typeof(MyCustomAttribute));
            if(classAttribute!=null)
            {
                System.Console.WriteLine("custom attribte "+classAttribute.Developername);
                System.Console.WriteLine("custom attribute "+classAttribute.Version);
            }

            System.Console.WriteLine("--------------------------");

            // MethodInfo methodInfo=t.GetMethod("ShowResult");
            // var methodAttribute=(MyCustomAttribute)Attribute.GetCustomAttribute(methodInfo,typeof(MyCustomAttribute));

            // if(methodAttribute!=null)
            // {
            //     System.Console.WriteLine($"method developer company :- {methodAttribute.Developername}");
            //     System.Console.WriteLine("method developer company :- "+methodAttribute.Version);
            // }

            System.Console.WriteLine("-------------------");
            
            // foreach(Attribute a in t.GetCustomAttributes(true))
            // {
            //     MyCustomAttribute c=(MyCustomAttribute)a;
            //     System.Console.WriteLine("Custom Attribute :- "+c.Developername);
            //     System.Console.WriteLine("Custome Attribute :- "+c.Version);
            // }
        }
    }
}
