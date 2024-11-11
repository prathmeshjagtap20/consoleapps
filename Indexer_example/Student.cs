using System;
namespace Indexer_example
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }


        public override string ToString()
        {
            return "${id},{name},{gender}";
        }
    }
}