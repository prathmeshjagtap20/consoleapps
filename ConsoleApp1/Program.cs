using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //             Console.WriteLine("Hello World!");


            // int Radius=Convert.ToInt32(Console.ReadLine());
            // double ans=3.14*Radius*Radius;
            //             System.Console.WriteLine($"The area of circle is {ans}");




            // System.Console.WriteLine("Enter the no :- ");
            // int no = Convert.ToInt32(Console.ReadLine());
            // if (no != 0)
            // {
            //     if (no > 0)
            //     {
            //         if (no % 2 == 0)
            //         {
            //             System.Console.WriteLine("The no is positive and even no");
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("The no is positive and odd no ");
            //         }
            //     }
            //     else
            //     {
            //         if (no % 2 == 0)
            //         {
            //             System.Console.WriteLine("The no is negative and even no");
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("The no is negative and odd no ");
            //         }

            //     }
            // }
            // else
            // {
            //     System.Console.WriteLine("The no is zero ");

            // }


            // System.Console.WriteLine("Enter the Operations like +,-,x,/ ");
            // char c = Convert.ToChar(Console.ReadLine());
            // System.Console.WriteLine("Enter the value of no1 :");
            // int no1 = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Enter the value of no2 :");
            // int no2 = Convert.ToInt32(Console.ReadLine());
            // int no3 = 0;


            // switch (c)
            // {
            //     case '+':
            //         no3 = no1 + no2;
            //         System.Console.WriteLine("The addition of two no is " + no3);
            //         break;

            //     case '-':
            //         no3 = no1 - no2;
            //         System.Console.WriteLine("The substraction of two no is " + no3);
            //         break;

            //     case 'x':
            //     case 'X':
            //         no3 = no1 * no2;
            //         System.Console.WriteLine("The multiplication of two no is " + no3);
            //         break;

            //     case '/':

            //     if(no2==0)
            //     {
            //         System.Console.WriteLine("Enter the no2 as a non zero");
            //     }
            //         no3 = no1 / no2;
            //         System.Console.WriteLine("The division  of two no is " + no3);
            //         break;

            //     default:

            //         System.Console.WriteLine("Please Enter the char from +, -, *, /");

            //         break;
            // }





            // wap to do difference between the do while and while

            // int i=1;
            //             do{
            //                 System.Console.WriteLine("do while loop  !");
            //             }while(i!=1);



            //             while(i!=1)
            //             {
            //                 System.Console.WriteLine("while loop !");
            //             }



            // String[] fruits = new string[4];
            // fruits[0] = "mango";
            // fruits[1] = "banana";
            // fruits[2] = "apple";
            // fruits[3] = "pinaple";
            // Array.Sort(fruits);
            // foreach (String fruit in fruits)
            // {
            //     System.Console.WriteLine(fruit);
            // }




            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            // swap(a, b);


            // swap1(ref a, ref b);
            // System.Console.WriteLine("After swaping ");
            // System.Console.WriteLine("value of a is " + a);
            // System.Console.WriteLine("value of b is " + b);


            //     var a=24;
            //    a=334;
            //    a=34.3;  // error 





            //wap to write area of rectangle using ref and out keyward
            double c;

            rec(ref a, ref b, out c);








            // Add two no 

            // int a=Convert.ToInt32(Console.ReadLine());
            // int b=Convert.ToInt32(Console.ReadLine());

            // int c=a+b;

            // System.Console.WriteLine($"The addition of {a} and {b} is {c}");







        }


        static void swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            System.Console.WriteLine("After swapping value of a is " + a);
            System.Console.WriteLine("After swapping value of b is " + b);
        }



        public static void swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void rec(ref int a, ref int b, out double c)
        {
            c = a * b;

            System.Console.WriteLine("Area of rectangele is " + c);
        }
    }
}