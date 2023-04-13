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
  //  <connectionStrings>
  //<add name = "dbmathEntities" connectionString="metadata=res://*/Models.MyModel.csdl|res://*/Models.MyModel.ssdl|res://*/Models.MyModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=95.217.230.169;initial catalog=dbmath;user id=dbmath;password=xpIm43xpIm43xpIm43;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" /></connectionStrings>

    public class DISHEADController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: DISHEADs
        public ActionResult Index()
        {
            var dISHEADS = db.DISHEADS.Include(d => d.DISTYPE).Include(d => d.HEAD);
            return View(dISHEADS.ToList());
        }

        // GET: DISHEADs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISHEAD dISHEAD = db.DISHEADS.Find(id);
            if (dISHEAD == null)
            {
                return HttpNotFound();
            }
            return View(dISHEAD);
        }

        // GET: DISHEADs/Create
        public ActionResult Create()
        {
            ViewBag.DISTYPEFID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME");
            ViewBag.HEADS_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME");
            return View();
        }

        // POST: DISHEADs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DISHEAD_ID,DISTYPEFID,HEADS_FID,AMOUNT")] DISHEAD dISHEAD)
        {
            if (ModelState.IsValid)
            {
                db.DISHEADS.Add(dISHEAD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DISTYPEFID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dISHEAD.DISTYPEFID);
            ViewBag.HEADS_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dISHEAD.HEADS_FID);
            return View(dISHEAD);
        }

        // GET: DISHEADs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISHEAD dISHEAD = db.DISHEADS.Find(id);
            if (dISHEAD == null)
            {
                return HttpNotFound();
            }
            ViewBag.DISTYPEFID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dISHEAD.DISTYPEFID);
            ViewBag.HEADS_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dISHEAD.HEADS_FID);
            return View(dISHEAD);
        }

        // POST: DISHEADs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DISHEAD_ID,DISTYPEFID,HEADS_FID,AMOUNT")] DISHEAD dISHEAD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dISHEAD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DISTYPEFID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dISHEAD.DISTYPEFID);
            ViewBag.HEADS_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dISHEAD.HEADS_FID);
            return View(dISHEAD);
        }

        // GET: DISHEADs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DISHEAD dISHEAD = db.DISHEADS.Find(id);
            if (dISHEAD == null)
            {
                return HttpNotFound();
            }
            return View(dISHEAD);
        }

        // POST: DISHEADs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DISHEAD dISHEAD = db.DISHEADS.Find(id);
            db.DISHEADS.Remove(dISHEAD);
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
