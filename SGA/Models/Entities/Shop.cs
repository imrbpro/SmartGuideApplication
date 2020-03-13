using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopOwner { get; set; }
        public int? ShopLongitude { get; set; }
        public int? ShopLatitude { get; set; }
        public byte[] ShopImage { get; set; }
    }
}
