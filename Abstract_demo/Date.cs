using System;
namespace Abstract_demo
{
    class Date
    {
        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        //default construtor

        public Date()
        {
            Day = 15;
            Month = 8;
            Year = 1940;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;

           // System.Console.WriteLine(day+"/"+month+"/"+year);
        }



        public override string ToString()
        {
            return Day+"/"+Month+"/"+Year;
        }
    }

}