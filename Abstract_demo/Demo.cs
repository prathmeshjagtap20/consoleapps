namespace Abstract_demo
{
    class Demo
    {

        int a = 0;

        public Demo()
        {
            showDetails(ref a);
            System.Console.WriteLine(a);

        }

        public static void showDetails(ref int j)
        {

            j = 101;

        }




    }


}