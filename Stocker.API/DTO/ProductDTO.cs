using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.API.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public decimal Stock { get; set; }
        public decimal MinimumAccepted { get; set; }
        public decimal MinimumRequired { get; set; }
    }
}
