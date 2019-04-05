using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public String SID { get; set; }
        public int CatPawsID { get; set; }
        public bool Done { get; set; }

    }
}