using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? ShopId { get; set; }
        public int? BrandId { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
