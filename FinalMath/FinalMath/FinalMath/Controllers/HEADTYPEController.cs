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
    public class HEADTYPEController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: HEADTYPE
        public ActionResult Index()
        {
            return View(db.HEADTYPES.ToList());
        }

        // GET: HEADTYPE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEADTYPE hEADTYPE = db.HEADTYPES.Find(id);
            if (hEADTYPE == null)
            {
                return HttpNotFound();
            }
            return View(hEADTYPE);
        }

        // GET: HEADTYPE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HEADTYPE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HEADTYPE_ID,HEAD_TYPE,isActive")] HEADTYPE hEADTYPE)
        {
            if (ModelState.IsValid)
            {
                db.HEADTYPES.Add(hEADTYPE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hEADTYPE);
        }

        // GET: HEADTYPE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEADTYPE hEADTYPE = db.HEADTYPES.Find(id);
            if (hEADTYPE == null)
            {
                return HttpNotFound();
            }
            return View(hEADTYPE);
        }

        // POST: HEADTYPE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HEADTYPE_ID,HEAD_TYPE,isActive")] HEADTYPE hEADTYPE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hEADTYPE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hEADTYPE);
        }

        // GET: HEADTYPE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HEADTYPE hEADTYPE = db.HEADTYPES.Find(id);
            if (hEADTYPE == null)
            {
                return HttpNotFound();
            }
            return View(hEADTYPE);
        }

        // POST: HEADTYPE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HEADTYPE hEADTYPE = db.HEADTYPES.Find(id);
            db.HEADTYPES.Remove(hEADTYPE);
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
