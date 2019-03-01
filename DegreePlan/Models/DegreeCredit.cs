using System;

                using System.Collections.Generic;

                namespace DegreePlan.Models

                {

                    public class DegreeCredit

                    {

                        public int ID { get; set; }

                        public ICollection<DegreeID> DegreeID { get; set; }

                        public ICollection<CreditID> CreditID { get; set; }

                    }

                }