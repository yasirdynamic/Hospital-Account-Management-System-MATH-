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
    public class DUEController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: DUE
        public ActionResult Index()
        {
            var dues = new DUEVM();
            //var dUES = db.DUES.Include(d => d.DISTYPE).Include(d => d.HEAD).Include(d => d.MODES_OF_PAYMENTS).Include(d => d.USER).Include(d => d.VENDOR);

            //return View(dUES.Where(x => x.DUES_ID == -1).ToList());
            return View(dues);
        }
        public ActionResult Search(DUEVM VM)
        {
            var data = new DUEVM();
            //var dUES = db.DUES.Include(d => d.DISTYPE).Include(d => d.HEAD).Include(d => d.MODES_OF_PAYMENTS).Include(d => d.USER).Include(d => d.VENDOR);
            var dUES = db.DUES.ToList();
            data.LstDue = dUES;
            if (VM.datefrom.Year > 2020)
            {
                data.LstDue = data.LstDue.Where(x => x.DATE >= VM.datefrom).ToList();
            }
            if (VM.dateto.Year > 2020)
            {
                data.LstDue = data.LstDue.Where(x => x.DATE <= VM.dateto).ToList();
            }
            if (!string.IsNullOrEmpty(VM.VoucherNO))
            {
                data.LstDue = data.LstDue.Where(x => x.VOUCHER_NO == VM.VoucherNO).ToList();
            }

            return PartialView("Index", data);
        }

        // GET: DUE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUE dUE = db.DUES.Find(id);
            if (dUE == null)
            {
                return HttpNotFound();
            }
            return View(dUE);
        }

        // GET: DUE/Create
        public ActionResult Create()
        {
            ViewBag.DISTYPE_FID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME");
            ViewBag.HEAD_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME");
            ViewBag.MODES_OF_PAYMENTS_FID = new SelectList(db.MODES_OF_PAYMENTS, "MODES_OF_PAYMENTS_ID", "MODES_OF_PAYMENT_NAME");
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME");
            ViewBag.VENDOR_FID = new SelectList(db.VENDORS, "VENDOR_ID", "VENDOR_NAME");
            return View();
        }

        // POST: DUE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DUE dUE)
        {


            if (dUE.due_photo != null)
            {
                String path = "~/images/" + Path.GetFileName(dUE.due_photo.FileName);

                dUE.due_photo.SaveAs(Server.MapPath(path));
                dUE.PIC = path;
            }

            db.DUES.Add(dUE);
            db.SaveChanges();
            ViewBag.DISTYPE_FID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dUE.DISTYPE_FID);
            ViewBag.HEAD_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dUE.HEAD_FID);
            ViewBag.MODES_OF_PAYMENTS_FID = new SelectList(db.MODES_OF_PAYMENTS, "MODES_OF_PAYMENTS_ID", "MODES_OF_PAYMENT_NAME", dUE.MODES_OF_PAYMENTS_FID);
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", dUE.USER_FID);
            ViewBag.VENDOR_FID = new SelectList(db.VENDORS, "VENDOR_ID", "VENDOR_NAME", dUE.VENDOR_FID);
            return RedirectToAction("Index", "DUE");


        }

        // GET: DUE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUE dUE = db.DUES.Find(id);
            if (dUE == null)
            {
                return HttpNotFound();
            }
            ViewBag.DISTYPE_FID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dUE.DISTYPE_FID);
            ViewBag.HEAD_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dUE.HEAD_FID);
            ViewBag.MODES_OF_PAYMENTS_FID = new SelectList(db.MODES_OF_PAYMENTS, "MODES_OF_PAYMENTS_ID", "MODES_OF_PAYMENT_NAME", dUE.MODES_OF_PAYMENTS_FID);
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", dUE.USER_FID);
            ViewBag.VENDOR_FID = new SelectList(db.VENDORS, "VENDOR_ID", "VENDOR_NAME", dUE.VENDOR_FID);
            return View(dUE);
        }

        // POST: DUE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DUE dUE)
        {
            if (dUE.due_photo != null)
            {
                string path = "~/images/" + Path.GetFileName(dUE.due_photo.FileName);

                dUE.due_photo.SaveAs(Server.MapPath(path));
                dUE.PIC = path;
            }
            db.Entry(dUE).State = EntityState.Modified;
            db.SaveChanges();
            ViewBag.DISTYPE_FID = new SelectList(db.DISTYPEs, "DISTYPE_ID", "DISTYPENAME", dUE.DISTYPE_FID);
            ViewBag.HEAD_FID = new SelectList(db.HEADS, "HEAD_ID", "HEAD_NAME", dUE.HEAD_FID);
            ViewBag.MODES_OF_PAYMENTS_FID = new SelectList(db.MODES_OF_PAYMENTS, "MODES_OF_PAYMENTS_ID", "MODES_OF_PAYMENT_NAME", dUE.MODES_OF_PAYMENTS_FID);
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", dUE.USER_FID);
            ViewBag.VENDOR_FID = new SelectList(db.VENDORS, "VENDOR_ID", "VENDOR_NAME", dUE.VENDOR_FID);
            return RedirectToAction("Index");



        }

        // GET: DUE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUE dUE = db.DUES.Find(id);
            if (dUE == null)
            {
                return HttpNotFound();
            }
            return View(dUE);
        }

        // POST: DUE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DUE dUE = db.DUES.Find(id);
            db.DUES.Remove(dUE);
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
