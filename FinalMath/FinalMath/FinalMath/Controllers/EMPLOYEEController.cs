using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalMath.Models;

namespace FinalMath.Controllers
{
    public class EMPLOYEEController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: EMPLOYEE
        public ActionResult Index()
        {
            return View(db.EMPLOYEES.ToList());
        }

        // GET: EMPLOYEE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEES.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // GET: EMPLOYEE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLOYEE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EMPLOYEE eMPLOYEE)
        {
            //eMPLOYEE.EMPLOYEE_TYPE = eMPLOYEE.emp_type.ToString();
            if (eMPLOYEE.emp_photo != null)
            {
                String path = "~/images/" + Path.GetFileName(eMPLOYEE.emp_photo.FileName);

                eMPLOYEE.emp_photo.SaveAs(Server.MapPath(path));
                eMPLOYEE.EMPLOYEE_PHOTO = path;
            }

            db.EMPLOYEES.Add(eMPLOYEE);
            db.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }

        // GET: EMPLOYEE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEES.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // POST: EMPLOYEE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EMPLOYEE eMPLOYEE)
        {
            //eMPLOYEE.EMPLOYEE_TYPE = eMPLOYEE.emp_type.ToString();


            if (eMPLOYEE.emp_photo != null)
            {
                string path = "~/images/" + Path.GetFileName(eMPLOYEE.emp_photo.FileName);

                eMPLOYEE.emp_photo.SaveAs(Server.MapPath(path));
                eMPLOYEE.EMPLOYEE_PHOTO = path;
            }
            db.Entry(eMPLOYEE).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: EMPLOYEE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEES.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // POST: EMPLOYEE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE eMPLOYEE = db.EMPLOYEES.Find(id);
            db.EMPLOYEES.Remove(eMPLOYEE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
