using System;

                using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models

                {

                    public class Degreeplan

                    {

                        [DatabaseGenerated(DatabaseGeneratedOption.None)]
                        public int DegreeplanId { get; set; }
                        public int StudentId { get; set; }
                        public String DegreePlanAbv { get; set; }
                        public String DegreePlanName{ get; set; }
                        public int DegreeId { get; set; }
                        public Student Student { get; set; }
                        public Degree Degree { get; set; }

                    }

                }