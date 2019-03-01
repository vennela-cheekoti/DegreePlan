using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Student
    {
        public int SlotID { get; set; }
        public string Status { get; set; }
        

        public ICollection<DegreePlan> DegreePlan { get; set; }
        public ICollection<Degree> Term { get; set; }
        public ICollection<DegreeCredit> CreditID { get; set; }

    }
}