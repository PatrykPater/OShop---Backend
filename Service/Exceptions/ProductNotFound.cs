using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class ProductNotFound : Exception
    {
        public ProductNotFound()
        {
        }

        public ProductNotFound(string message)
            : base(message)
        {
        }

        public ProductNotFound(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
