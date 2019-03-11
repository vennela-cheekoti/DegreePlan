using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Slot
    {
        public int SlotId { get; set; }
        public string Status { get; set; }
        public int DegreePlan { get; set; }
        public int Term { get; set; }
        public int CreditId { get; set; }

       

    }
}