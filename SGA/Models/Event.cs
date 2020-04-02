using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Event
    {
        public int EventId { get; set; }
        public int ShopId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime DateTime { get; set; }

    }
}
