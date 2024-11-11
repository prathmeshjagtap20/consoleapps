using System;
using System.Collections.Generic;


namespace Collection_demo
{
    class SortedList
    {
        static void Main(string[] args)
        {

            
            // SortedList<int, string> list = new SortedList<int, string>();
            // list.Add(1, "Prathmesh");
            // list.Add(4, "vk");
            // list.Add(2, "sk");


            // foreach (KeyValuePair<int, string> p in list)
            // {
            //     System.Console.WriteLine(p.Key + " " + p.Value);
            // }


            // System.Console.WriteLine("\n");



            // SortedDictionary<int,string>dic=new SortedDictionary<int, string>();
            // dic.Add(4,"pj");
            // dic.Add(1,"sk");
            // dic.Add(2,"sk");
            // dic.Add(3,"pj");

            // foreach(KeyValuePair<int,string>pair in dic)
            // {
            //     System.Console.WriteLine(pair.Key+" "+pair.Value);
            // }



            SortedSet<int>set=new SortedSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(4);
            set.Add(3);


            foreach(var name in set)
            {
                System.Console.WriteLine(name);
            }

        







        }



    }
}