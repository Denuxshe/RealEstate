using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private RealEstateContext realEContext = new RealEstateContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            realEContext.owners.Add(owner);
            realEContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult CreateStaff(Staff staff)
        {
            realEContext.staffs.Add(staff);
            realEContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult CreateRent(Rent rent)
        {
            realEContext.rents.Add(rent);
            realEContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult CreateBranch(Branch branch)
        {
            realEContext.branchs.Add(branch);
            realEContext.SaveChanges();
            return View();
        }

    }
}