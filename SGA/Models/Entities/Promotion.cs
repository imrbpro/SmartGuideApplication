using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Promotion
    {
        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string PromotionDetails { get; set; }
        public int? BrandId { get; set; }
        public int? ShopId { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Endtdate { get; set; }
    }
}
