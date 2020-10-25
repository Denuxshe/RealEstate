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
            List<Rent> allRents = realEContext.rents.ToList();
            return View(allRents);
        }
        public ActionResult Create()
        {
            ViewBag.rentDetails = new SelectList(realEContext.owners, "OwnerNo", "OwnerNo");
            ViewBag.staffDetails = new SelectList(realEContext.staffs, "StaffNo", "StaffNo");
            ViewBag.branchDetails= new SelectList(realEContext.branchs, "BranchNo", "BranchNo");

            return View();      
        }
        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            realEContext.rents.Add(rent);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Rent Rents = realEContext.rents.SingleOrDefault(x => x.propertyNo== id);
            return View(Rents);
        }
        public ActionResult Edit(String id)
        {
            ViewBag.Rents = new SelectList(realEContext.owners, "OwnerNo", "Address");
            ViewBag.Stafs = new SelectList(realEContext.staffs, "StaffNo", "Position");
            ViewBag.Bran = new SelectList(realEContext.branchs, "BranchNo", "Street");
            Rent Rents = realEContext.rents.SingleOrDefault(x => x.propertyNo== id);
            return View(Rents);
        }
        [HttpPost]
        public ActionResult Edit(String id, Rent UpdateRent)
        {
            Rent rent = realEContext.rents.SingleOrDefault(x => x.propertyNo== id);
            rent.street= UpdateRent.street;
            rent.city = UpdateRent.city;
            rent.ptype = UpdateRent.ptype;
            rent.rooms = UpdateRent.rooms;
            rent.ownerNoref= UpdateRent.ownerNoref;
            rent.staffNoref = UpdateRent.staffNoref;
            rent.branchNoRef = UpdateRent.branchNoRef;
            realEContext.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(String id)
        {
            Rent Rents = realEContext.rents.SingleOrDefault(x => x.propertyNo== id);
            return View(Rents);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteRent(String id)
        {
            Rent rent = realEContext.rents.SingleOrDefault(x => x.propertyNo== id);
            realEContext.rents.Remove(rent);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}