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
    public class SALARiesController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: SALARies
        public ActionResult Index()
        {
            var sALARies = db.SALARies.Include(s => s.EMPLOYEE).ToList();          
           
            return View(sALARies.ToList());
        }

        // GET: SALARies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALARY sALARY = db.SALARies.Find(id);
            if (sALARY == null)
            {
                return HttpNotFound();
            }
            return View(sALARY);
        }

        // GET: SALARies/Create
        public ActionResult Create()
        {
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME");
            return View();
        }

        // POST: SALARies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SALARY sALARY)
        {
            var emp = db.EMPLOYEES.Where(x => x.EMPLOYEE_ID == sALARY.EMPLOYEE_FID).FirstOrDefault();
            sALARY.TOTAL_SALARY=(decimal.Parse(emp.EMPLOYEE_MONTHLY_SALARY.ToString())+ decimal.Parse(emp.EMPLOYEE_ALLOWENCES.ToString())+ decimal.Parse(sALARY.EXTRA_DUTY)).ToString();
            DateTime date = DateTime.Parse(sALARY.SALARY_DATE.ToString());
            int monthno = date.Month;
            int year = date.Year;
            int nodays = DateTime.DaysInMonth(year, monthno);
            sALARY.ABSENT_AMOUNT = Math.Round((decimal.Parse(emp.EMPLOYEE_MONTHLY_SALARY.ToString()) / nodays) * decimal.Parse(sALARY.ABSENT_DAYS.ToString())).ToString();           
            
            sALARY.NET_SALARY = (decimal.Parse(sALARY.TOTAL_SALARY.ToString()) - decimal.Parse(sALARY.ADVANCE_AMOUNT.ToString()) - decimal.Parse(sALARY.ABSENT_AMOUNT.ToString())).ToString();
            
            
            
            if (ModelState.IsValid)
            {
                db.SALARies.Add(sALARY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", sALARY.EMPLOYEE_FID);
            return View(sALARY);
        }

        // GET: SALARies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALARY sALARY = db.SALARies.Find(id);
            if (sALARY == null)
            {
                return HttpNotFound();
            }
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", sALARY.EMPLOYEE_FID);
            return View(sALARY);
        }

        // POST: SALARies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SALARY sALARY)
        {
            var emp = db.EMPLOYEES.Where(x => x.EMPLOYEE_ID == sALARY.EMPLOYEE_FID).FirstOrDefault();
            sALARY.TOTAL_SALARY = (decimal.Parse(emp.EMPLOYEE_MONTHLY_SALARY.ToString()) + decimal.Parse(emp.EMPLOYEE_ALLOWENCES.ToString()) + decimal.Parse(sALARY.EXTRA_DUTY)).ToString();
            DateTime date = DateTime.Parse(sALARY.SALARY_DATE.ToString());
            int monthno = date.Month;
            int year = date.Year;
            int nodays = DateTime.DaysInMonth(year, monthno);
            sALARY.ABSENT_AMOUNT = Math.Round((decimal.Parse(emp.EMPLOYEE_MONTHLY_SALARY.ToString()) / nodays) * decimal.Parse(sALARY.ABSENT_DAYS.ToString())).ToString();

            sALARY.NET_SALARY = (decimal.Parse(sALARY.TOTAL_SALARY.ToString()) - decimal.Parse(sALARY.ADVANCE_AMOUNT.ToString()) - decimal.Parse(sALARY.ABSENT_AMOUNT.ToString())).ToString();

            if (ModelState.IsValid)
            {
                db.Entry(sALARY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EMPLOYEE_FID = new SelectList(db.EMPLOYEES, "EMPLOYEE_ID", "EMPLOYEE_NAME", sALARY.EMPLOYEE_FID);
            return View(sALARY);
        }

        // GET: SALARies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALARY sALARY = db.SALARies.Find(id);
            if (sALARY == null)
            {
                return HttpNotFound();
            }
            return View(sALARY);
        }

        // POST: SALARies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SALARY sALARY = db.SALARies.Find(id);
            db.SALARies.Remove(sALARY);
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
