using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        public string DegreeAbv { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
        public bool Done { get; set; }

    }
}