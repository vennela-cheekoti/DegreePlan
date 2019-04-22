using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DegreePlan.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Status { get; set; }
        public int DegreePlanId { get; set; }
        [Range(0, 20)]
        public int Term { get; set; }
        public int CreditId { get; set; }
        public Degreeplan DegreePlan { get; set; }
        public Credit Credit { get; set; }

        public override string ToString()
        {
            return base.ToString() + " PlanNumber = " + SlotId + "DegreeStatus =" + Status;
        }

    }
}