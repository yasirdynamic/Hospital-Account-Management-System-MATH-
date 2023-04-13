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
    public class VENDORController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: VENDOR
        public ActionResult Index()
        {
            return View(db.VENDORS.ToList());
        }

        // GET: VENDOR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORS.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDOR);
        }

        // GET: VENDOR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VENDOR/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VENDOR vENDOR)
        {
            if (vENDOR.vendor_photo != null)
            {
                String path = "~/images/" + Path.GetFileName(vENDOR.vendor_photo.FileName);

                vENDOR.vendor_photo.SaveAs(Server.MapPath(path));
                vENDOR.VENDOR_PIC = path;
            }

            db.VENDORS.Add(vENDOR);
            db.SaveChanges();
            return RedirectToAction("Index", "VENDOR");
        }

        // GET: VENDOR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORS.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDOR);
        }

        // POST: VENDOR/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VENDOR vENDOR)
        {
            if (vENDOR.vendor_photo != null)
            {
                string path = "~/images/" + Path.GetFileName(vENDOR.vendor_photo.FileName);

                vENDOR.vendor_photo.SaveAs(Server.MapPath(path));
                vENDOR.VENDOR_PIC = path;
            }
            db.Entry(vENDOR).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: VENDOR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORS.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDOR);
        }

        // POST: VENDOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VENDOR vENDOR = db.VENDORS.Find(id);
            db.VENDORS.Remove(vENDOR);
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
