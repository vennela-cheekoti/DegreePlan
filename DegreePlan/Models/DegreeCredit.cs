using System;

                using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models

                {

                    public class DegreeCredit

                    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditId { get; set; }
                        public int DegreeId { get; set; }
                        public int CreditId { get; set; }



        

                    }

                }