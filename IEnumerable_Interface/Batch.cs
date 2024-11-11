using System.Collections;

namespace IEnumerable_Interface
{
    class Batch : IEnumerable
    {
        public int id { get; set; }

        Student[] stu = new Student[6];
        public Batch()
        {
            id = 1;
            stu = new Student[6];
            {

                stu[0] = new Student() { id = 1, name = "Pj" };
                stu[1] = new Student() { id = 2, name = "vj" };
                stu[2] = new Student() { id = 3, name = "dj" };
                stu[3] = new Student() { id = 4, name = "dj" };
                stu[4] = new Student() { id = 5, name = "fj" };
                stu[5] = new Student() { id = 6, name = "Pdj" };

            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Student student in stu)
            {
                yield return student;
            }
        }
    }
}