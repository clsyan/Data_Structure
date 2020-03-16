using System;

namespace vector_array
{
    class EIndexOutOfRange:Exception
    {
        public EIndexOutOfRange(string ex) : base(ex)
        {
            
        }
    }
}