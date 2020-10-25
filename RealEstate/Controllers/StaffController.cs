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
            List<Staff> allStaff = realEContext.staffs.ToList();
            return View(allStaff);
        }
        public ActionResult Create()
        {
            ViewBag.branchDetails = realEContext.branchs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            realEContext.staffs.Add(staff);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Staff staff = realEContext.staffs.SingleOrDefault(x => x.staffNo== id);
            return View(staff);
        }
        public ActionResult Edit(String id)
        {
            ViewBag.Braninfro = new SelectList(realEContext.branchs, "BranchNo", "Street", "Branchref");
            Staff staff = realEContext.staffs.SingleOrDefault(x => x.staffNo== id);
            return View(staff);
        }
        [HttpPost]
        public ActionResult Edit(String id, Staff UpdateStaff)
        {
            Staff Stafs = realEContext.staffs.SingleOrDefault(x => x.staffNo== id);
            Stafs.fName = UpdateStaff.fName;
            Stafs.lName = UpdateStaff.lName;
            Stafs.position = UpdateStaff.position;
            Stafs.dateOfBirth = UpdateStaff.dateOfBirth;
            Stafs.salary = UpdateStaff.salary;
            Stafs.branchNoRef = UpdateStaff.branchNoRef;
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {

            Staff staff = realEContext.staffs.SingleOrDefault(x => x.staffNo == id);
            return View(staff);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteEmployee(String id)
        {
            Staff staff = realEContext.staffs.SingleOrDefault(x => x.staffNo == id);
            realEContext.staffs.Remove(staff);
            realEContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}