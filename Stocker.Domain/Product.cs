using Stocker.Domain.Enums;
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
        public EnumProductType Type { get; set; }
        public string TypeName { get { return Type.ToString(); } }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string CategoryName { get { return Category != null ? Category.Name : null; } }
        public decimal Stock { get; set; }
        public decimal MinimumAccepted { get; set; }
        public decimal MinimumRequired { get; set; }
        public bool Active { get; set; }
    }
}
