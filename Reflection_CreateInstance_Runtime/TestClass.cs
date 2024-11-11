using System;
namespace Reflection_CreateInstance_Runtime
{
    class TestClass
    {
        private int testvalue=43;
        public int TestMethod(int n)
        {
            return this.testvalue+n;
        }
        public int Add(int a,int b)
        {
            return a+b;
        }
    }
}