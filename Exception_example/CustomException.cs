using System;

namespace Exception_example
{
    class CustomException:ApplicationException
    {

        public CustomException(string msg):base(msg)
        {

        }

    }
}