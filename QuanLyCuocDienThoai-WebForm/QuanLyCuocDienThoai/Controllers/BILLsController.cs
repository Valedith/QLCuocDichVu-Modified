using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using QuanLyCuocDienThoai.Models;
using QuanLyCuocDienThoai.ViewModels;

namespace QuanLyCuocDienThoai.Controllers
{
    public class BILLsController : Controller
    {
        private QLCuocDTEntities db = new QLCuocDTEntities();

        // GET: BILLs
        public ActionResult Index(string id, string simID)
        {
            var account = db.ACCOUNTs.Where(s => s.EMAIL == id + "@gmail.com").FirstOrDefault();
            var sim = db.SIMs.Where(s => s.ID_CUSTOMER == account.ID_CUSTOMER);
            ViewBag.simID = new SelectList(sim, "ID_SIM", "PHONENUMBER");
            var bILL = db.BILLs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            if (!String.IsNullOrEmpty(simID)) //Truong hop chi loc theo sdt
            {
                sim = sim.Where(s => s.ID_SIM.Contains(simID));
                bILL = db.BILLs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            }
            bILL = db.BILLs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            /*var dETAIL = db.DETAILs.Where(s => sim.Any(s2 => s2.ID_SIM == s.ID_SIM));
            var billdetails = from s in dETAIL
                              group s by s.ID_SIM into detailgroup
                              select new
                              {
                                  ID_SIM = detailgroup.Key,

                                  MINUTEUSED = dETAIL.Sum(x => x.MINUTE_AFTER7) + dETAIL.Sum(x => x.MINUTE_AFTER23),
                              };*/
            return View(bILL.ToList());
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
