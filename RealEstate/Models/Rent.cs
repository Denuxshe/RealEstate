using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    [Table("Rent_tbl")] //renaming table
    public class Rent
    {
        [Key] //denotes primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //prevent from auto numbering
        public string propertyNo { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string ptype { get; set; }
        public int rooms{ get; set; }

        [ForeignKey("owner")]
        public string ownerNoref  { get; set; }
        public Owner owner { get; set; }

        [ForeignKey("staff")]
        public string staffNoref { get; set; }
        public Staff staff { get; set; }

        [ForeignKey("branch")]
        public string branchNoRef { get; set; }
        public Branch branch { get; set; }

        public int rent { get; set; }
    }
}