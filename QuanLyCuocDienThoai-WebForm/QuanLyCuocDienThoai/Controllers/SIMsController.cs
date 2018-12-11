using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyDienThoaiEntity.Models;

namespace QuanLyCuocDienThoai.Controllers
{
    public class SIMsController : Controller
    {
        private QLYCUOCDTEntities db = new QLYCUOCDTEntities();

        // GET: SIMs
        public ActionResult Index()
        {
            var sIMs = db.SIMs.Include(s => s.CUSTOMER);
            return View(sIMs.ToList());
        }

        // GET: SIMs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIM sIM = db.SIMs.Find(id);
            if (sIM == null)
            {
                return HttpNotFound();
            }
            return View(sIM);
        }

        // GET: SIMs/Create
        public ActionResult Create()
        {
            ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME");
            return View();
        }

        // POST: SIMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SIM,ID_CUSTOMER,PHONENUMBER,STATUS")] SIM sIM)
        {
            if (ModelState.IsValid)
            {
                db.SIMs.Add(sIM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME", sIM.ID_CUSTOMER);
            return View(sIM);
        }

        // GET: SIMs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIM sIM = db.SIMs.Find(id);
            if (sIM == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME", sIM.ID_CUSTOMER);
            return View(sIM);
        }

        // POST: SIMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SIM,ID_CUSTOMER,PHONENUMBER,STATUS")] SIM sIM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME", sIM.ID_CUSTOMER);
            return View(sIM);
        }

        // GET: SIMs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIM sIM = db.SIMs.Find(id);
            if (sIM == null)
            {
                return HttpNotFound();
            }
            return View(sIM);
        }

        // POST: SIMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SIM sIM = db.SIMs.Find(id);
            db.SIMs.Remove(sIM);
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
