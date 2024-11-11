namespace MyLibrary;


    public class MyMath
    {

        public  int a;
        public int b;
        public  int c;



      


        public  void Add(int a,int b)
        {
            c=a+b;
            System.Console.WriteLine(" "+a+" + "+b+"="+c);
        }

         public  void Sub(int a,int b)
        {
            c=a-b;
            System.Console.WriteLine(" "+a+" - "+b+"="+c);
        }

         public void Mult(int a,int b)
        {
            c=a*b;
            System.Console.WriteLine(" "+a+" x "+b+"="+c);
        }

         public  void Div(int a,int b)
        {
            c=a/b;
            System.Console.WriteLine(" "+a+" / "+b+"="+c);
        }

    }

