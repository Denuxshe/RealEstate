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
            List<Owner> Owners = realEContext.owners.ToList();
            return View(Owners);
        }
        public ActionResult Create()
        {
            ViewBag.ownerDetails = realEContext.owners;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            realEContext.owners.Add(owner);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Owner Owners = realEContext.owners.SingleOrDefault(x => x.ownerNo== id);
            return View(Owners);
        }
        public ActionResult Edit(String id)
        {
            Owner Owners = realEContext.owners.SingleOrDefault(x => x.ownerNo== id);
            return View(Owners);
        }
        [HttpPost]
        public ActionResult Edit(String id, Owner UpdateOwner)
        {
            Owner Owners = realEContext.owners.SingleOrDefault(x => x.ownerNo== id);
            Owners.fName= UpdateOwner.fName;
            Owners.lName = UpdateOwner.lName;
            Owners.address = UpdateOwner.address;
            Owners.telNo = UpdateOwner.telNo;
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Owner Ownerss = realEContext.owners.SingleOrDefault(x => x.ownerNo== id);
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult UpdateDelete(String id)
        {
            Owner ownerX = realEContext.owners.SingleOrDefault(x => x.ownerNo== id);
            realEContext.owners.Remove(ownerX);
            realEContext.SaveChanges();
            RedirectToAction("Index");

            return View();

        }
    }
}