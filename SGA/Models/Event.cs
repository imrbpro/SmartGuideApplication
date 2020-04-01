using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Event
    {
        public int eventid { get; set; }
        public int shopid { get; set; }
        public int brandid { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public DateTime dateTime { get; set; }

    }
}
