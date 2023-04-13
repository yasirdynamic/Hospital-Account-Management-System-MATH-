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
    public class USERTYPEController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: USERTYPE
        public ActionResult Index()
        {
            return View(db.USERTYPES.ToList());
        }

        // GET: USERTYPE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USERTYPE uSERTYPE = db.USERTYPES.Find(id);
            if (uSERTYPE == null)
            {
                return HttpNotFound();
            }
            return View(uSERTYPE);
        }

        // GET: USERTYPE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: USERTYPE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "USERTYPE_ID,USER_TYPE,IsActive")] USERTYPE uSERTYPE)
        {
            if (ModelState.IsValid)
            {
                db.USERTYPES.Add(uSERTYPE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uSERTYPE);
        }

        // GET: USERTYPE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USERTYPE uSERTYPE = db.USERTYPES.Find(id);
            if (uSERTYPE == null)
            {
                return HttpNotFound();
            }
            return View(uSERTYPE);
        }

        // POST: USERTYPE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "USERTYPE_ID,USER_TYPE,IsActive")] USERTYPE uSERTYPE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSERTYPE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uSERTYPE);
        }

        // GET: USERTYPE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USERTYPE uSERTYPE = db.USERTYPES.Find(id);
            if (uSERTYPE == null)
            {
                return HttpNotFound();
            }
            return View(uSERTYPE);
        }

        // POST: USERTYPE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            USERTYPE uSERTYPE = db.USERTYPES.Find(id);
            db.USERTYPES.Remove(uSERTYPE);
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
