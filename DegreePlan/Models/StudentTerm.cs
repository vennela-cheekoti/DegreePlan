using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; set; }
        public int Term { get; set; }
        public string TermAbv { get; set; }
        public string TermName { get; set; }

        public int StudentID { get; set; }
        public int DegreeplanID { get; set; }
        
    }
}