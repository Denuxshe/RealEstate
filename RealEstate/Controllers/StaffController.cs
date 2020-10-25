using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class StaffController : Controller
    {
        private RealEstateContext realEContext = new RealEstateContext();
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.staffDetails = realEContext.staffs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            realEContext.staffs.Add(staff);
            realEContext.SaveChanges();
            return View();
        }
    }
}