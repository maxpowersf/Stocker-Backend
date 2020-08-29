using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Stock { get; set; }
        public decimal MinimumAccepted { get; set; }
        public decimal MinimumRequired { get; set; }
    }
}
