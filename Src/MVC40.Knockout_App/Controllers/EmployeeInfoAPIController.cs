using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage PostEmployeeInfo(EmployeeInfo employeeInfo)
        {
            if(ModelState.IsValid)
            {
                db.EmployeeInfoes.Add(employeeInfo);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, employeeInfo);
                response.Headers.Location = new Uri(Url.Link("DefaultApi",new{employeeInfo.EmpNo}));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
       
        //PUT
        public HttpResponseMessage PutEmployeeInfo(int id, EmployeeInfo employeeInfo)
        {
            if(ModelState.IsValid && id == employeeInfo.EmpNo)
            {
                db.Entry(employeeInfo).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        
        //DELETE
        public HttpResponseMessage DeleteEmployeeInfo(int id)
        {
            EmployeeInfo employeeInfo = db.EmployeeInfoes.Find(id);
            if(employeeInfo == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.EmployeeInfoes.Remove(employeeInfo);
            try
            {
                db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, employeeInfo);
        }
        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}