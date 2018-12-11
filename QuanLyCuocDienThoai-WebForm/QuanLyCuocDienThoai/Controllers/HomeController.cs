using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyDienThoaiEntity.Models;

namespace QuanLyCuocDienThoai.Controllers
{
	public class HomeController : Controller
	{
		private QLYCUOCDTEntities db = new QLYCUOCDTEntities();

		[Authorize]
        public ActionResult Index()
        {
            return View();
        }

		// GET: ACCOUNTs/Edit/5
		public ActionResult ChangePassword(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ACCOUNT aCCOUNT = db.ACCOUNTs.Find(id);
			if (aCCOUNT == null)
			{
				return HttpNotFound();
			}
			ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME", aCCOUNT.ID_CUSTOMER);
			return View(aCCOUNT);
		}

		// POST: ACCOUNTs/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult ChangePassword([Bind(Include = "ID_CUSTOMER,PASSWORD,CONFIRMPASSWORD,ISEMAILVERIFY,ACTIVATIONCODE,RESETPASSWORDCODE")] ACCOUNT aCCOUNT)
		{
			if (ModelState.IsValid)
			{
				db.Entry(aCCOUNT).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			ViewBag.ID_CUSTOMER = new SelectList(db.CUSTOMERs, "ID_CUSTOMER", "NAME", aCCOUNT.ID_CUSTOMER);
			return View(aCCOUNT);
		}

		// GET: BILLs/Details/5
		public ActionResult BillDetails(string id)
		{
			var bILLs = db.BILLs.Include(b => b.SIM);
			return View(bILLs.ToList());
			//if (id == null)
			//{
			//	return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			//}
			//BILL bILL = db.BILLs.Find(id);
			//if (bILL == null)
			//{
			//	return HttpNotFound();
			//}
			//return View(bILL);
		}

		//public ActionResult SearchBill (string StartDate, string EndDate)
		//{
		//	var result = db.BILLs.Where(a => a.ID_SIM == id)
		//		.Where(a => a.DATE_EXPORT >= DateTime.ParseExact(StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture))
		//		.Where(a => a.DATE_CUT <= DateTime.ParseExact(EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture));
		//	return PartialView("AdvanceSearch", result);
		//}
	}
}