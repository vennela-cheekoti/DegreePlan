using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public string Status { get; set; }
        public int DegreePlan { get; set; }
        public int Term { get; set; }
        public int CreditID { get; set; }

       

    }
}