using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalMath.Models;

namespace FinalMath.Controllers
{
    public class USERController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: USER
        public ActionResult Index()
        {
            var uSERS = db.USERS.Include(u => u.EMPLOYEE).Include(u => u.USERTYPE);
            return View(uSERS.ToList());
        }

        // GET: USER/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER uSER = db.USERS.Find(id);
            if (uSER == null)
            {
                return HttpNotFound();
            }
            return View(uSER);
        }

        // GET: USER/Create
        public ActionResult Create()
        {
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME");
            ViewBag.USERTYPE_FID = new SelectList(db.USERTYPES, "USERTYPE_ID", "USER_TYPE");
            return View();
        }

        // POST: USER/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "USER_ID,USERTYPE_FID,EMPLOYEE_FID,USER_NAME,USER_PASSWORD,IsActive")] USER uSER)
        {
            if (ModelState.IsValid)
            {
                db.USERS.Add(uSER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", uSER.EMPLOYEE_FID);
            ViewBag.USERTYPE_FID = new SelectList(db.USERTYPES, "USERTYPE_ID", "USER_TYPE", uSER.USERTYPE_FID);
            return View(uSER);
        }

        // GET: USER/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER uSER = db.USERS.Find(id);
            if (uSER == null)
            {
                return HttpNotFound();
            }
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", uSER.EMPLOYEE_FID);
            ViewBag.USERTYPE_FID = new SelectList(db.USERTYPES, "USERTYPE_ID", "USER_TYPE", uSER.USERTYPE_FID);
            return View(uSER);
        }

        // POST: USER/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "USER_ID,USERTYPE_FID,EMPLOYEE_FID,USER_NAME,USER_PASSWORD,IsActive")] USER uSER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", uSER.EMPLOYEE_FID);
            ViewBag.USERTYPE_FID = new SelectList(db.USERTYPES, "USERTYPE_ID", "USER_TYPE", uSER.USERTYPE_FID);
            return View(uSER);
        }

        // GET: USER/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER uSER = db.USERS.Find(id);
            if (uSER == null)
            {
                return HttpNotFound();
            }
            return View(uSER);
        }

        // POST: USER/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            USER uSER = db.USERS.Find(id);
            db.USERS.Remove(uSER);
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
