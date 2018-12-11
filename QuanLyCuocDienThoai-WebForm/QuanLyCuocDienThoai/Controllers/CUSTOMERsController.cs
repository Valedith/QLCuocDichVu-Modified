using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using QuanLyDienThoaiEntity.Models;

namespace QuanLyCuocDienThoai.Controllers
{
    public class CUSTOMERsController : Controller
    {
        private QLYCUOCDTEntities db = new QLYCUOCDTEntities();

        // GET: CUSTOMERs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return Logout();
            }
            var account = db.ACCOUNTs.Where(s => s.EMAIL == id+"@gmail.com");
            CUSTOMER cUSTOMER = db.CUSTOMERs.Find(account.Select(s=>s.ID_CUSTOMER).FirstOrDefault());
            if (cUSTOMER == null)
            {
                return HttpNotFound();
            }
            return View(cUSTOMER);
        }

        // POST: CUSTOMERs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CUSTOMER,NAME,IDENTIFY,JOB,POSITION,ADDRESS")] CUSTOMER cUSTOMER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cUSTOMER).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.SuccessMessage = "Sửa thành công.";
            }
            else
            {
                ViewBag.FailMessage = "Sửa không thành công.";
            }
            return View(cUSTOMER);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login", "ACCOUNTs");
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
