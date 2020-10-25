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
        [Display(Name = "Branch No")]
        public string branchNo { get; set; }
        [Display(Name = "Street")]

        public string Street { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "Post Code")]
        public string postcode { get; set; }

    }
}