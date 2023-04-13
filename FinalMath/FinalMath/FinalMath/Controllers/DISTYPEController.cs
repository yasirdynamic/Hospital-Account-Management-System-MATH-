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
    public class DISTYPEController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: DISTYPE
        public ActionResult Index()
        {
            return View(db.DISTYPEs.ToList());
        }

        // GET: DISTYPE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISTYPE dISTYPE = db.DISTYPEs.Find(id);
            if (dISTYPE == null)
            {
                return HttpNotFound();
            }
            return View(dISTYPE);
        }

        // GET: DISTYPE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DISTYPE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DISTYPE_ID,DISTYPENAME")] DISTYPE dISTYPE)
        {
            if (ModelState.IsValid)
            {
                db.DISTYPEs.Add(dISTYPE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dISTYPE);
        }

        // GET: DISTYPE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISTYPE dISTYPE = db.DISTYPEs.Find(id);
            if (dISTYPE == null)
            {
                return HttpNotFound();
            }
            return View(dISTYPE);
        }

        // POST: DISTYPE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DISTYPE_ID,DISTYPENAME")] DISTYPE dISTYPE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dISTYPE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dISTYPE);
        }

        // GET: DISTYPE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISTYPE dISTYPE = db.DISTYPEs.Find(id);
            if (dISTYPE == null)
            {
                return HttpNotFound();
            }
            return View(dISTYPE);
        }

        // POST: DISTYPE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DISTYPE dISTYPE = db.DISTYPEs.Find(id);
            db.DISTYPEs.Remove(dISTYPE);
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
