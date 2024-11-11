// to manage the large code for that we have use the partial class and partial method.
// In that the class name is same.


namespace Partial_class
{
    partial class MyForm
    {
        public string name { get; set; }

        public string Description { get; set; }

     public   partial void Greet(string s2);

   
    }
}