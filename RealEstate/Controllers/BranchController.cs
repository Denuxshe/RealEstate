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
            List<Branch> branches = realEContext.branchs.ToList();
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
        public ActionResult Edit(String id)
        {
            Branch branches = realEContext.branchs.SingleOrDefault(x => x.branchNo == id);
            return View(branches);
        }
        [HttpPost]
        public ActionResult Edit(String id, Branch UpdateBranch)
        {
            Branch branches = realEContext.branchs.SingleOrDefault(x => x.branchNo == id);
            branches.Street = UpdateBranch.Street;
            branches.city= UpdateBranch.city;
            branches.branchNo= UpdateBranch.branchNo;
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Branch branches = realEContext.branchs.SingleOrDefault(x => x.branchNo== id);
            return View();
        }
        [HttpPost, ActionName("DeleteBranch")]
        public ActionResult DeleteBranch(String id)
        {
            Branch branches = realEContext.branchs.SingleOrDefault(x => x.branchNo == id);
            realEContext.branchs.Remove(branches);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Branch branches = realEContext.branchs.SingleOrDefault(x => x.branchNo== id);
            return View(branches);
        }


    }
}