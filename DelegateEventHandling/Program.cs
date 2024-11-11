using System;

namespace DelegateEventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student s1=new Student(){Id=1,Name="pj"};
            // s1.Pass+=new Markdel(ShowMessage.ShowGoodMsg);
            // s1.Fail+=new Markdel(ShowMessage.ShowBadMsg);

            // s1.EnterMarks(60);
            int live=DateTime.Now.Hour;

             Student1 obj=new Student1();
            obj.GM+=new StuMsg(ShowMessage1.ShowGM);
            obj.GA+=new StuMsg(ShowMessage1.ShowGF);
            obj.GE+=new StuMsg(ShowMessage1.ShowGE);
            obj.GN+=new StuMsg(ShowMessage1.ShowGN);

           // obj.EnterHours(23);

            obj.LiveHours(live);
        }
    }
}