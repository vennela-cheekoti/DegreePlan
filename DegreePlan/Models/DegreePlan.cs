using System;

                using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DegreePlan.Models

                {

                    public class Degreeplan

                    {

                        [DatabaseGenerated(DatabaseGeneratedOption.None)]
                        public int DegreeplanId { get; set; }
                        public int StudentId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public String DegreePlanAbv { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public String DegreePlanName{ get; set; }
                        public int DegreeId { get; set; }
                        public Student Student { get; set; }
                        public Degree Degree { get; set; }
                        public DegreeCredit DegreeCredit { get; set; }

       public ICollection<StudentTerm> StudentTerms { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "StudentDegreePlanId = " + DegreeplanId +
              "StudentId = " + StudentId +
              ", DegreeId = " + DegreeId +
              ", PlanAbbrev = " + DegreePlanAbv +
              ", PlanName = " + DegreePlanName +
              ", Student ={" + Student.ToString() +
                            "}, Degree = {" + Degree.ToString() +
                           "}";
        }

    }

                }