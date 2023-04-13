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
    public class HEADController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: HEAD
        public ActionResult Index()
        {
            var hEADS = db.HEADS.Include(h => h.HEADTYPE);
            return View(hEADS.ToList());
        }

        // GET: HEAD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEAD hEAD = db.HEADS.Find(id);
            if (hEAD == null)
            {
                return HttpNotFound();
            }
            return View(hEAD);
        }

        // GET: HEAD/Create
        public ActionResult Create()
        {
            ViewBag.HEADTYPE_FID = new SelectList(db.HEADTYPES, "HEADTYPE_ID", "HEAD_TYPE");
            return View();
        }

        // POST: HEAD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HEAD_ID,HEADTYPE_FID,HEAD_NAME,isActive")] HEAD hEAD)
        {
            if (ModelState.IsValid)
            {
                db.HEADS.Add(hEAD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HEADTYPE_FID = new SelectList(db.HEADTYPES, "HEADTYPE_ID", "HEAD_TYPE", hEAD.HEADTYPE_FID);
            return View(hEAD);
        }

        // GET: HEAD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEAD hEAD = db.HEADS.Find(id);
            if (hEAD == null)
            {
                return HttpNotFound();
            }
            ViewBag.HEADTYPE_FID = new SelectList(db.HEADTYPES, "HEADTYPE_ID", "HEAD_TYPE", hEAD.HEADTYPE_FID);
            return View(hEAD);
        }

        // POST: HEAD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HEAD_ID,HEADTYPE_FID,HEAD_NAME,isActive")] HEAD hEAD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hEAD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HEADTYPE_FID = new SelectList(db.HEADTYPES, "HEADTYPE_ID", "HEAD_TYPE", hEAD.HEADTYPE_FID);
            return View(hEAD);
        }

        // GET: HEAD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEAD hEAD = db.HEADS.Find(id);
            if (hEAD == null)
            {
                return HttpNotFound();
            }
            return View(hEAD);
        }

        // POST: HEAD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HEAD hEAD = db.HEADS.Find(id);
            db.HEADS.Remove(hEAD);
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
