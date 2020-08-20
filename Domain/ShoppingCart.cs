using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ShoppingCart : BaseEntity
    {
        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }

        public int? UserId { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
