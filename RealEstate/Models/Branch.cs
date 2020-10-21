using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    [Table("Branch_tbl")]
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please fillup the ID", AllowEmptyStrings = false)]

        public string branchNo { get; set; }
        public string Street { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }

    }
}