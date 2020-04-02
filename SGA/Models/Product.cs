using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public string ProductImage { get; set; }
    }
}
