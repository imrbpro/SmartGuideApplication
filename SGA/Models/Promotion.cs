using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int BrandId { get; set; }
        public int ShopId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
