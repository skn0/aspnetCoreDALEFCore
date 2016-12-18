using System;
using System.Collections.Generic;

namespace Abc.DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
