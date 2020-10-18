using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        public int staffNo { get; set; }
        public string fName{ get; set; }
        public string lName { get; set; }
        public string position { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int salary { get; set; }

        [ForeignKey("branch")]        
        public int branchNo { get; set; }
        public Branch branch { get; set; }

    }
}