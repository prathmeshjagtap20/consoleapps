using System;
namespace Task_Demo
{
    class Program1
    {
        static async Task Main(string[] args)
        {

            System.Console.WriteLine("starting tasks..");
            //start multiple tasks concurrently

            Task<int> task1=Task.Run(()=>PerformCalculation(10));
            Task<int> task2=Task.Run(()=>PerformCalculation(20));
                        Task<int> task3=Task.Run(()=>PerformCalculation(30));

                        //wait for all tasks to complete and gather their results


                        int[] results=await Task.WhenAll(task1,task2,task3);

                        //Process the results

                        System.Console.WriteLine("Results :");
                        foreach(int result in results)
                        {
                            System.Console.WriteLine(result);
                        }
            

        }


        static int PerformCalculation(int number)
        {
            int result=number*number;
            Task.Delay(2000);
            System.Console.WriteLine($"Calculated square of {number} as {result}");
            return result;
        }
    }
}