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
        public string staffNo { get; set; }
        public string fName{ get; set; }
        public string lName { get; set; }
        public string position { get; set; }
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        public int salary { get; set; }

        [ForeignKey("branch")]        
        public string branchNoRef { get; set; }
        public Branch branch { get; set; }

    }
}