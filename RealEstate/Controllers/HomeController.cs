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
        public ActionResult filterStaff()
        {
            List<Staff> allStaff = realEContext.staffs.ToList();
            return View(allStaff);
        }

        public ActionResult filterBuildings()
        {
            List<Rent> allRents = realEContext.rents.ToList();
            return View(allRents);
        }
        public ActionResult BranchCount(String id)
        {
            var rent = realEContext.rents.Where(x => x.branchNoRef== id).ToList();
            ViewBag.count = rent;
            return View();
        }
    }
}