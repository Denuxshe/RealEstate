using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class OwnerController : Controller
    {
        private RealEstateContext realEContext = new RealEstateContext();

        // GET: Owner
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.ownerDetails = realEContext.owners;
            return View();
        }
        public ActionResult Create(Owner owner)
        {
            realEContext.owners.Add(owner);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}