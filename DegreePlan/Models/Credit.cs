using System;
using System.Collections.Generic;

namespace Degreeplan.Models
{
    public class Credit
    {
        public int ID { get; set; }
        public string CreditAbv { get; set; }
        public string CreditName { get; set; }
        public int isSummer { get; set; }
        public int isSpring { get; set; }
        public int isFall { get; set; }
    }
}