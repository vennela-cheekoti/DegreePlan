using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        public int Term { get; set; }
        public string TermAbv { get; set; }
        public string TermName { get; set; }
        public int StudentId { get; set; }
        public int DegreeplanId { get; set; }
        public Student Student { get; set; }
        public Degreeplan Degreeplan { get; set; }
    }
}