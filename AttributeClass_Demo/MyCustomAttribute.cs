using System;

namespace AttributeClass_Demo
{
    [AttributeUsage(AttributeTargets.All)]
    class MyCustomAttribute:System.Attribute
    {
        public string Developername { get; set; }
        public double Version { get; set; }

        public MyCustomAttribute(string Developername, double Version)
        {
            this.Developername=Developername;
            this.Version=Version;
        }

    }
}