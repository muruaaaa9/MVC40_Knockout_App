using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MVC40.Knockout_App.Models;

namespace MVC40.Knockout_App.Controllers
{
    public class EmployeeInfoAPIController : ApiController
    {
        private companyContext db = new companyContext();

        //
        // GET: /EmployeeInfoAPI/

        public IEnumerable<EmployeeInfo> GetEmployeeInfoes()
        {
            return db.EmployeeInfoes.AsEnumerable();
        }

        //
        // GET: /EmployeeInfoAPI/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
        //    if (employeeinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeeinfo);
        //}

        

       
        //
        // POST: /EmployeeInfoAPI/Create

        //[System.Web.Mvc.HttpPost]
        //public ActionResult Create(EmployeeInfo employeeinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.EmployeeInfoes.Add(employeeinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(employeeinfo);
        //}

        //
        // GET: /EmployeeInfoAPI/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
        //    if (employeeinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeeinfo);
        //}

        ////
        //// POST: /EmployeeInfoAPI/Edit/5

        //[System.Web.Mvc.HttpPost]
        //public ActionResult Edit(EmployeeInfo employeeinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(employeeinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employeeinfo);
        //}

        ////
        //// GET: /EmployeeInfoAPI/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
        //    if (employeeinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeeinfo);
        //}

        ////
        //// POST: /EmployeeInfoAPI/Delete/5

        //[System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
        //    db.EmployeeInfoes.Remove(employeeinfo);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}