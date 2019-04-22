using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DegreePlan.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string FamilyName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string GivenName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public String SID { get; set; }
        [Range(0,20)]
        public int CatPawsID { get; set; }
        public bool Done { get; set; }

        public ICollection<Degreeplan> Degreeplans { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "StudentId = " + StudentId +
              "GivenName = " + GivenName +
              ", FamilyName = " + FamilyName +
              "";
        }

    }
}