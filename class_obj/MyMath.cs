
namespace class_obj
{
    static class MyMath
    {

        public static int a;
        public static int b;
        public static int c;



        static MyMath()
        {
            a=200;
            b=100;
            System.Console.WriteLine("Static constructor executed:- ");

        }


        public static void Add()
        {
            c=a+b;
            System.Console.WriteLine(" "+a+" + "+b+"="+c);
        }

         public static void Sub()
        {
            c=a-b;
            System.Console.WriteLine(" "+a+" - "+b+"="+c);
        }

         public static void Mult()
        {
            c=a*b;
            System.Console.WriteLine(" "+a+" x "+b+"="+c);
        }

         public static void Div()
        {
            c=a/b;
            System.Console.WriteLine(" "+a+" / "+b+"="+c);
        }





    }
}