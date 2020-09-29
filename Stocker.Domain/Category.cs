using Stocker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnumCategoryType Type { get; set; }
        public string TypeName { get { return Type.ToString(); } }
    }
}
