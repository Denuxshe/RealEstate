using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    [Table("Owner_tbl")]
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please fillup the ID", AllowEmptyStrings = false)]
        [Display(Name = "Owner Number")]
        public string ownerNo { get; set; }

        [Display(Name = "First Name")]
        public string fName { get; set; }
        [Display(Name = "Last Name")]
        public string lName { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "TeleNo")]
        public string telNo { get; set; }

        public virtual List<Rent> rents { get; set; }

    }
}