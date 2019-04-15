using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DegreePlan.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        [Range(0,20)]
        public int Term { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string TermAbv { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string TermName { get; set; }
        public int DegreeplanId { get; set; }
        public Degreeplan DegreePlan{get; set;}
        
    }
}