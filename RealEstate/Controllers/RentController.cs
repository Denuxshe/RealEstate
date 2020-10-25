using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class RentController : Controller
    {
        private RealEstateContext realEContext = new RealEstateContext();
        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.rentDetails = realEContext.rents;
            return View();
        }
        public ActionResult Create(Rent rent)
        {
            realEContext.rents.Add(rent);
            realEContext.SaveChanges();
            return View();
        }
    }
}