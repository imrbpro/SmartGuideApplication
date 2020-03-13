using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Event
    {
        public int EventId { get; set; }
        public int? ShopId { get; set; }
        public int? BrandId { get; set; }
        public string EventName { get; set; }
        public string EventDetails { get; set; }
        public DateTime? EventDatetime { get; set; }
    }
}
