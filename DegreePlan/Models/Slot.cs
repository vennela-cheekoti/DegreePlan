using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        public string Status { get; set; }
        [ForeignKey("DegreePlanId")]
        public int DegreePlanId { get; set; }
        public int Term { get; set; }
        [ForeignKey("CreditId")]
        public int CreditId { get; set; }

       

    }
}