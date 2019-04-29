using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DegreePlan.Models
{
    public class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditId { get; set; }
        [StringLength(50,MinimumLength=3)]
        public string CreditAbv { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string CreditName { get; set; }
        [Range(0,20)]
        public int IsSummer { get; set; }
        [Range(0, 20)]
        public int IsSpring { get; set; }
        [Range(0, 20)]
        public int IsFall { get; set; }
        public bool Done { get; set; }
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
       
    }
}