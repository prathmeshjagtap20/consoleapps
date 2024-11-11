// using System;
// namespace LINQ_Demo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = { 1, 2, 3, 4, 3, 533, 49, 90, 43, 32 };
//             var result = from n in numbers where n % 2 != 0 orderby n select n;

//             System.Console.WriteLine("odd Variables  -----------");

//             foreach (var n in result)
//             {

//                 System.Console.WriteLine(n);
//             }

//             System.Console.WriteLine("Digits with i ---------------------");


//             string[] words = { "one ", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
//             var result2 = (from w in words where w[1] == 'i' select w).Reverse();

//             foreach (var a in result2)
//             {
//                 System.Console.WriteLine(a);
//             }
//             System.Console.WriteLine("Start with As-------------");



//             string[] musicians = { "Ashok Kumar", "Kishor Kumar", "Asha Bhosale", "Lata Mangeshkar", "Sonu Nigam" };
//             var result3 = from n in musicians
//                               //where n.StartsWith("As")
//                               //where n.EndsWith("Kumar");
//                           where n.Contains("Sonu")
//                           select n;

//             foreach (var n in result3)
//             {
//                 System.Console.WriteLine(n);
//             }

//             System.Console.WriteLine("-----------------------------");
//             System.Console.WriteLine("Union of two array ");
//             int[] numA = { 12, 3, 54, 3, 2, 5, 6, 7, 5, 2, 4 };
//             int[] numB = { 1, 2, 3, 4, 5, 5, 67, 7, 8, 9, 9 };
//             var result4 = numA.Union(numB);
//             foreach (var n in result4)
//             {
//                 System.Console.Write(n + " ");
//             }
//             System.Console.WriteLine();

//             System.Console.WriteLine("Intersection of two array ");
//             var result5 = numA.Intersect(numB);
//             foreach (var n in result5)
//             {
//                 System.Console.Write(n + " ");
//             }
//             System.Console.WriteLine();

//             System.Console.WriteLine("numA except numB of 2 array ");

//             var result6 = numA.Except(numB);
//             foreach (var n in result6)
//             {
//                 System.Console.Write(n + " ");
//             }

//             System.Console.WriteLine();

//             string[] cities = { "Mumbai", "Pune", "Indore", "Hydrabad", "Solapur" };
//             var result7 = cities.Distinct();
//             foreach (var n in result7)
//             {
//                 System.Console.WriteLine(n);
//             }



//             //Aggregate function 

//             int sum = numbers.Sum();
//             System.Console.WriteLine($"Sum of elements {sum}");
//             int max = numbers.Max();
//             System.Console.WriteLine("Maximum elements is :- " + max);
//             int min = numbers.Min();
//             System.Console.WriteLine("Minimum elements is :-" + min);
//             double avg = numbers.Average();
//             System.Console.WriteLine("Avg of the array is :- " + avg);
//             int count = numbers.Count();
//             System.Console.WriteLine("Count of elements is :- " + count);

//             string[] words1 = { "Believe", "Relief", "Receive", "Chief" };
//             //any operator works like or operator
//             bool IAfterE = words1.Any(w => w.Contains("ei"));


//             System.Console.WriteLine("Words array contains is sequence " + IAfterE);
//             // all operator works like And operator
//             bool EAfterI = words1.All(w => w.Contains("ie"));
//             System.Console.WriteLine("Words array contains all elements " + EAfterI);


//         }
//     }
// }