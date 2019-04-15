using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DegreePlan.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DegreeAbv { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DegreeName { get; set; }
        [Range(0,20)]
        public int NumberOfTerms { get; set; }
        public bool Done { get; set; }

    }
}