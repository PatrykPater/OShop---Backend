using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
