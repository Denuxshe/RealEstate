using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    public class RealEstateContext:DbContext
    {

        public DbSet<Staff> staffs { get; set; }
        public DbSet<Rent> rents { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<Branch> branchs { get; set; }
    }
}