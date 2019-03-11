using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class StudentTerm
    {
        public int StudentTermId { get; set; }
        public int Term { get; set; }
        public string TermAbv { get; set; }
        public string TermName { get; set; }

        public int StudentId { get; set; }
        public int DegreeplanId { get; set; }
        
    }
}