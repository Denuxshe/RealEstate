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
        public string ownerNo  { get; set; }
        public Owner owner { get; set; }

        [ForeignKey("staff")]
        public string staffNo { get; set; }
        public Staff staff { get; set; }

    }
}