using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Credit
    {
        public int ID { get; set; }
        public string CreditAbv { get; set; }
        public string CreditName { get; set; }
        public int IsSummer { get; set; }
        public int IsSpring { get; set; }
        public int IsFall { get; set; }
    }
}