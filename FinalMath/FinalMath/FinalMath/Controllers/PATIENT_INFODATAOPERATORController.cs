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
    public class PATIENT_INFODATAOPERATORController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: PATIENT_INFODATAOPERATOR
        public ActionResult Index()
        {
          
            
                Session["Message"] = "Hello MVC!";
                var pATIENT_INFO = db.PATIENT_INFO.Include(p => p.USER);
                return View(pATIENT_INFO.ToList());
              
           
        }

        // GET: PATIENT_INFODATAOPERATOR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PATIENT_INFO pATIENT_INFO = db.PATIENT_INFO.Find(id);
            if (pATIENT_INFO == null)
            {
                return HttpNotFound();
            }
            return View(pATIENT_INFO);
        }

        // GET: PATIENT_INFODATAOPERATOR/Create
        public ActionResult Create()
        {
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME");
            return View();
        }

        // POST: PATIENT_INFODATAOPERATOR/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PATIENT_INFO pATIENT_INFO)
        {
            
                db.PATIENT_INFO.Add(pATIENT_INFO);
                db.SaveChanges();
                return RedirectToAction("Index", "PATIENT_INFODATAOPERATOR");

        }

        // GET: PATIENT_INFODATAOPERATOR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PATIENT_INFO pATIENT_INFO = db.PATIENT_INFO.Find(id);
            if (pATIENT_INFO == null)
            {
                return HttpNotFound();
            }
            List<string> catlist = new List<string>()
            {
                "NP","LNP","Deserving","LFC","Free","Others"
            };
            ViewBag.Cat= new SelectList(catlist, "CATEGORY", "CATEGORY");
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", pATIENT_INFO.USER_FID);
            return View(pATIENT_INFO);
        }

        // POST: PATIENT_INFODATAOPERATOR/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PATIENT_INFO pATIENT_INFO)
        {
                db.Entry(pATIENT_INFO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "PATIENT_INFODATAOPERATOR");
            
        }

        // GET: PATIENT_INFODATAOPERATOR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PATIENT_INFO pATIENT_INFO = db.PATIENT_INFO.Find(id);
            if (pATIENT_INFO == null)
            {
                return HttpNotFound();
            }
            return View(pATIENT_INFO);
        }

        // POST: PATIENT_INFODATAOPERATOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PATIENT_INFO pATIENT_INFO = db.PATIENT_INFO.Find(id);
            db.PATIENT_INFO.Remove(pATIENT_INFO);
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
