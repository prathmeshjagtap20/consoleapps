using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
namespace Indexer_example
{
    class Batch
    {
        List<Student> list;
        public Batch()
        {
            list = new List<Student>();
            list.Add(new Student() { id = 101, name = "prathmesh", gender = "Male" });
            list.Add(new Student() { id = 102, name = "prathm", gender = "Male" });
            list.Add(new Student() { id = 103, name = "prathme", gender = "Male" });
            list.Add(new Student() { id = 104, name = "prathmes", gender = "Male" });
            list.Add(new Student() { id = 105, name = "prathmesh jagtap", gender = "Male" });
        }

        public string this[int Id]
        {
            get
            {
                //select name from list where id=Id;
                return list.FirstOrDefault(x => x.id == Id).name;
            }

            set
            {
                list.FirstOrDefault(x => x.id == Id).name = value;
            }
        }

        public int this[string nm]
        {
            get
            {
                //select id from is wher name=nm;
                return list.FirstOrDefault(x => x.name.ToLower() == nm.ToLower()).id;
            }

            set
            {
                list.FirstOrDefault(x=>x.name==nm).id=value;
            }
        }

    }
}