using System;

namespace StringMethod
{
    class HashCode
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string :- ");
            string s = Console.ReadLine();
            string[] str = s.Split(" ");
            string[] str1 = new string[s.Length+s.Length];
            int k=0;

            for (int i = 0; i < str.Length; i++)
            {
                char[] ch = str[i].ToCharArray();
                for (int j = 0; j < ch.Length; j++)
                {
                    if(ch[i]=='#' && ch[j]=='#')
                    {
                        i=j;
                        str1[k]=s.Substring(i,j-1);
                        k++;
                    }
                }
            }

          System.Console.WriteLine(str1);


        }
    }
}
