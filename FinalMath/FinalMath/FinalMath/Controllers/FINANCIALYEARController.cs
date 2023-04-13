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
    public class FINANCIALYEARController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: FINANCIALYEAR
        public ActionResult Index()
        {
            return View(db.FINANCIALYEARS.ToList());
        }

        // GET: FINANCIALYEAR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FINANCIALYEAR fINANCIALYEAR = db.FINANCIALYEARS.Find(id);
            if (fINANCIALYEAR == null)
            {
                return HttpNotFound();
            }
            return View(fINANCIALYEAR);
        }

        // GET: FINANCIALYEAR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FINANCIALYEAR/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FINANCIALYEAR_ID,FINANCIAL_YEAR,START_DATE,END_DATE,OPENING_BALANCE,isActive")] FINANCIALYEAR fINANCIALYEAR)
        {
            if (ModelState.IsValid)
            {
                db.FINANCIALYEARS.Add(fINANCIALYEAR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fINANCIALYEAR);
        }

        // GET: FINANCIALYEAR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FINANCIALYEAR fINANCIALYEAR = db.FINANCIALYEARS.Find(id);
            if (fINANCIALYEAR == null)
            {
                return HttpNotFound();
            }
            return View(fINANCIALYEAR);
        }

        // POST: FINANCIALYEAR/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FINANCIALYEAR_ID,FINANCIAL_YEAR,START_DATE,END_DATE,OPENING_BALANCE,isActive")] FINANCIALYEAR fINANCIALYEAR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fINANCIALYEAR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fINANCIALYEAR);
        }

        // GET: FINANCIALYEAR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FINANCIALYEAR fINANCIALYEAR = db.FINANCIALYEARS.Find(id);
            if (fINANCIALYEAR == null)
            {
                return HttpNotFound();
            }
            return View(fINANCIALYEAR);
        }

        // POST: FINANCIALYEAR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FINANCIALYEAR fINANCIALYEAR = db.FINANCIALYEARS.Find(id);
            db.FINANCIALYEARS.Remove(fINANCIALYEAR);
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
