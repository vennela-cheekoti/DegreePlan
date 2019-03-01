using System;

                using System.Collections.Generic;

                namespace DegreePlan.Models

                {

                    public class DegreePlan

                    {

                                public int ID { get; set; }
                                
                                public ICollection<Student> StudentID { get; set; }

                                public String DegreePlanAbv { get; set; }

                                public String DegreePlanName{ get; set; }

                                public ICollection<Degree> DegreeID { get; set; }

                    }

                }