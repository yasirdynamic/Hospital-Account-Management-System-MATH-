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
    public class MODES_OF_PAYMENTSController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: MODES_OF_PAYMENTS
        public ActionResult Index()
        {
            return View(db.MODES_OF_PAYMENTS.ToList());
        }

        // GET: MODES_OF_PAYMENTS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MODES_OF_PAYMENTS mODES_OF_PAYMENTS = db.MODES_OF_PAYMENTS.Find(id);
            if (mODES_OF_PAYMENTS == null)
            {
                return HttpNotFound();
            }
            return View(mODES_OF_PAYMENTS);
        }

        // GET: MODES_OF_PAYMENTS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MODES_OF_PAYMENTS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MODES_OF_PAYMENTS_ID,MODES_OF_PAYMENT_NAME,isActive")] MODES_OF_PAYMENTS mODES_OF_PAYMENTS)
        {
            if (ModelState.IsValid)
            {
                db.MODES_OF_PAYMENTS.Add(mODES_OF_PAYMENTS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mODES_OF_PAYMENTS);
        }

        // GET: MODES_OF_PAYMENTS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MODES_OF_PAYMENTS mODES_OF_PAYMENTS = db.MODES_OF_PAYMENTS.Find(id);
            if (mODES_OF_PAYMENTS == null)
            {
                return HttpNotFound();
            }
            return View(mODES_OF_PAYMENTS);
        }

        // POST: MODES_OF_PAYMENTS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MODES_OF_PAYMENTS_ID,MODES_OF_PAYMENT_NAME,isActive")] MODES_OF_PAYMENTS mODES_OF_PAYMENTS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mODES_OF_PAYMENTS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mODES_OF_PAYMENTS);
        }

        // GET: MODES_OF_PAYMENTS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MODES_OF_PAYMENTS mODES_OF_PAYMENTS = db.MODES_OF_PAYMENTS.Find(id);
            if (mODES_OF_PAYMENTS == null)
            {
                return HttpNotFound();
            }
            return View(mODES_OF_PAYMENTS);
        }

        // POST: MODES_OF_PAYMENTS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MODES_OF_PAYMENTS mODES_OF_PAYMENTS = db.MODES_OF_PAYMENTS.Find(id);
            db.MODES_OF_PAYMENTS.Remove(mODES_OF_PAYMENTS);
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
