using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Degree
    {
        public int DegreeId { get; set; }
        public string DegreeAbv { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }

    }
}