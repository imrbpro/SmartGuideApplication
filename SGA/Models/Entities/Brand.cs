using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ShopNo { get; set; }
        public string BrandOwner { get; set; }
        public byte[] BrandLogo { get; set; }
    }
}
