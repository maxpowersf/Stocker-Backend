using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Data.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public decimal Stock { get; set; }
        public decimal MinimumAccepted { get; set; }
        public decimal MinimumRequired { get; set; }
    }
}
