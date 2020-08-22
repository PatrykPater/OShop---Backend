using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CartItem : BaseEntity
    {
        public decimal Quantity { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
