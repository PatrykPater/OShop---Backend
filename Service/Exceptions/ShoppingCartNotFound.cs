using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Exceptions
{
    public class ShoppingCartNotFound : Exception
    {
        public ShoppingCartNotFound()
        {
        }

        public ShoppingCartNotFound(string message)
            : base(message)
        {
        }

        public ShoppingCartNotFound(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
