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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please fillup the ID", AllowEmptyStrings = false)]
        [Display(Name = "Staff No")]
        public string staffNo { get; set; }
        [Display(Name = "First Name")]
        public string fName{ get; set; }
        [Display(Name = "Last Name")]
        public string lName { get; set; }
        [Display(Name = "Position")]
        public string position { get; set; }
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime dateOfBirth { get; set; }
        [Display(Name = "Salary")]
        public int salary { get; set; }

        [ForeignKey("branch")]
        public string branchNoRef { get; set; }
        public Branch branch { get; set; }

    }
}