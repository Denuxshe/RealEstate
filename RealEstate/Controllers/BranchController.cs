using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class BranchController : Controller
    {
        private RealEstateContext realEContext = new RealEstateContext();
        // GET: Branch
        public ActionResult Index()
        {
         //   Branch branches = realEContext.branchs;
            return View(branches);
        }
        public ActionResult Create()
        {
            ViewBag.branchDetails = realEContext.branchs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            realEContext.branchs.Add(branch);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}