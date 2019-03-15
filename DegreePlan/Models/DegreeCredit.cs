using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DegreePlan.Models

{

    public class DegreeCredit

    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditId { get; set; }

        [ForeignKey("DegreeId")]
        public int DegreeId { get; set; }
        [ForeignKey("DegreeId")]
        public int CreditId { get; set; }
        
         





    }

}