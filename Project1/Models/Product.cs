using System;
using System.Collections.Generic;

#nullable disable

namespace Project1.Models
{
    public partial class Product
    {
        public Product()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
