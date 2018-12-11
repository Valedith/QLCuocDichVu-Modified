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
    public class DETAILsController : Controller
    {
        private QLYCUOCDTEntities db = new QLYCUOCDTEntities();

        // GET: DETAILs
        public ActionResult Index(string id, string simID, string StartDate, string EndDate)
        {
            if (id == null)
            {
                return Logout();
            }
            var account = db.ACCOUNTs.Where(s => s.EMAIL == id + "@gmail.com").FirstOrDefault();
            var sim = db.SIMs.Where(s => s.ID_CUSTOMER == account.ID_CUSTOMER);
            ViewBag.simID = new SelectList(sim, "ID_SIM", "PHONENUMBER");
            ViewBag.StartDate = StartDate;
            ViewBag.EndDate = EndDate;
            var dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            if (!String.IsNullOrEmpty(simID) && !String.IsNullOrEmpty(StartDate) && !String.IsNullOrEmpty(EndDate))
            {
                sim = sim.Where(s => s.ID_SIM.Contains(simID));
                try
                {
                    DateTime sdate = Convert.ToDateTime(StartDate);
                    DateTime edate = Convert.ToDateTime(EndDate);
                    dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM) && s.TIME_START >= sdate && s.TIME_STOP <= edate);
                }
                catch (Exception ex) //Truong hop loi dinh dang MM dd yyyy
                {
                    dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
                }
            }
            else if (!String.IsNullOrEmpty(simID)) //Truong hop chi loc theo sdt
            {
                sim = sim.Where(s => s.ID_SIM.Contains(simID));
                dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            }
            if (dETAIL == null)
            {
                return Logout();
            }
            return View(dETAIL.ToList());

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
