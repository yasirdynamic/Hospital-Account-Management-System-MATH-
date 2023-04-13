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
    public class PATIENT_INFOController : Controller
    {
        private dbmathEntities db = new dbmathEntities();

        // GET: PATIENT_INFO
        public ActionResult Index()
        {
            var pATIENT_INFO = db.PATIENT_INFO.Include(p => p.USER);
            return View(pATIENT_INFO.ToList());
        }

        // GET: PATIENT_INFO/Details/5
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

        // GET: PATIENT_INFO/Create
        public ActionResult Create()
        {
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME");
            return View();
        }

        // POST: PATIENT_INFO/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PATIENT_ID,REGISTRATION_NO,NAME,FATHER_NAME,DATE_OF_BIRTH,DATE_OF_ADDMISSION,MONTH,CONTACT,CATEGORY,AGE,CITY,ADDRESS,RELIGION,CHRONIC_MEDICAL_PROBLEM,CMP_SPECIFY,REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION,EDUCATION,OCCUPATION,DRUG_TYPE,R_O_A,REASON_FOR_SUBSTANCE_USE,HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE,REASON_BEHIND_RELAPSE,HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME,HC_SPECIFY,MARITAL_STATUS,LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL,LDA_SPECIFIER,YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY,SF_SPECIFY,HAS_ANY_ONE_ABUSED_YOU,EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE,EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS,EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS,TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS,PLAN_TO_HURT_OR_KILL_SOMEONE,SERIOUS_PLAN_FOR_KILLING_SELF,SUCIDE_ATTEMPTS,USER_FID,DATE_OF_DISCHARGE,IsActive")] PATIENT_INFO pATIENT_INFO)
        {
            if (ModelState.IsValid)
            {
                db.PATIENT_INFO.Add(pATIENT_INFO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", pATIENT_INFO.USER_FID);
            return View(pATIENT_INFO);
        }

        // GET: PATIENT_INFO/Edit/5
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
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", pATIENT_INFO.USER_FID);
            return View(pATIENT_INFO);
        }

        // POST: PATIENT_INFO/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PATIENT_ID,REGISTRATION_NO,NAME,FATHER_NAME,DATE_OF_BIRTH,DATE_OF_ADDMISSION,MONTH,CONTACT,CATEGORY,AGE,CITY,ADDRESS,RELIGION,CHRONIC_MEDICAL_PROBLEM,CMP_SPECIFY,REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION,EDUCATION,OCCUPATION,DRUG_TYPE,R_O_A,REASON_FOR_SUBSTANCE_USE,HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE,REASON_BEHIND_RELAPSE,HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME,HC_SPECIFY,MARITAL_STATUS,LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL,LDA_SPECIFIER,YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY,SF_SPECIFY,HAS_ANY_ONE_ABUSED_YOU,EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE,EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS,EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS,TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS,PLAN_TO_HURT_OR_KILL_SOMEONE,SERIOUS_PLAN_FOR_KILLING_SELF,SUCIDE_ATTEMPTS,USER_FID,DATE_OF_DISCHARGE,IsActive")] PATIENT_INFO pATIENT_INFO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pATIENT_INFO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.USER_FID = new SelectList(db.USERS, "USER_ID", "USER_NAME", pATIENT_INFO.USER_FID);
            return View(pATIENT_INFO);
        }

        // GET: PATIENT_INFO/Delete/5
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

        // POST: PATIENT_INFO/Delete/5
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
