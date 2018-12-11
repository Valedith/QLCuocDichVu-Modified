using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using QuanLyDienThoaiEntity.Models;

namespace QuanLyCuocDienThoai.Controllers
{
    public class ACCOUNTsController : Controller
    {
        //Tạo index cho các trang-----------------------
        private QLYCUOCDTEntities db = new QLYCUOCDTEntities();

        // GET: ACCOUNTs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return Logout();
            }
            ACCOUNT aCCOUNT = db.ACCOUNTs.Find(id+"@gmail.com");
            if (aCCOUNT == null)
            {
                return Logout();
            }
            return View(aCCOUNT);
        }

        // POST: ACCOUNTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMAIL,ID_CUSTOMER,PASSWORD,CONFIRMPASSWORD,ISEMAILVERIFY,ACTIVATIONCODE,RESETPASSWORDCODE")] ACCOUNT aCCOUNT)
        {
            if (ModelState.IsValid)
            {
                aCCOUNT.PASSWORD = MD5.Hash(aCCOUNT.PASSWORD);
                aCCOUNT.CONFIRMPASSWORD = MD5.Hash(aCCOUNT.CONFIRMPASSWORD);
                db.Entry(aCCOUNT).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.SuccessMessage = "Sửa thành công.";
            }
            else
            {
                ViewBag.FailMessage = "Sửa không thành công.";
            }
            return View(aCCOUNT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

		//Login

		[HttpGet]
		public ActionResult Login()
		{
			return View();
		}

		//Login POST

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(ACCOUNT login, string ReturnUrl = "")
		{
			string message = "";
			var v = db.ACCOUNTs.Where(a => a.EMAIL == login.EMAIL).FirstOrDefault();
			if (v != null)
			{
				if (string.Compare(MD5.Hash(login.PASSWORD), v.PASSWORD) == 0)
				{
                    int timeout = login.RememberMe ? 525600 : 20;
					var ticket = new FormsAuthenticationTicket(login.EMAIL, login.RememberMe, timeout);

					string encrypted = FormsAuthentication.Encrypt(ticket);
					var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);

					cookie.Expires = DateTime.Now.AddMinutes(timeout);
					cookie.HttpOnly = true;
					Response.Cookies.Add(cookie);
                    var name = v.EMAIL.Split('@');
                    Session.Add("Email",name[0]);

                    return RedirectToAction("Index", "Home", new { id = name[0] } );
				}
				else
				{
					message = "Tài khoản hoặc mật khẩu chưa đúng.";
				}
			}
			else
			{
				message = "Tài khoản không tồn tại.";
			}
			ViewBag.Message = message;
			return View();
		}

		//Logout

		[Authorize]
		[HttpPost]
		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			Session.Clear();
			return RedirectToAction("Login", "ACCOUNTs");
		}

		[NonAction]
		public void SendVerifycationLinkEmail(string Email, string ActivationCode, string emailFor = "ResetPassword")
		{
			var verifyUrl = "/ACCOUNTs/" + emailFor + "/" + ActivationCode;
			var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

			var fromEmail = new MailAddress("conduongtong@gmail.com", "Dotnet Awesome");
			var toEmail = new MailAddress(Email);

			var fromEmailPassword = "01217139209";

			string subject = "";
			string body = "";

			subject = "Đặt lại mật khẩu";

			body = "Xin chào, <br /><br /> Chúng tôi nhận được yêu cầu đặt lại mật khẩu tài khoản của bạn." +
					" Vui lòng nhấn vào link bên dưới để đặt lại mật khẩu" +
					" <br /><br /><a href=" + link + ">Đặt lại mật khẩu</a>";
			
			var smtp = new SmtpClient
			{
				Host = "smtp.gmail.com",
				Port = 587,
				EnableSsl = true,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
			};

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            }) try
                {
                    smtp.Send(message);
                }
                catch(Exception ex)
                {
                    ViewBag.Message = "Không có mạng";
                }

                
		}

		//Forgot password
		public ActionResult ForgotPassword()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ForgotPassword(string Email)
		{
			//Verify email
			//Generate reset password link
			//Send email
			string message = "";
				var account = db.ACCOUNTs.Where(a => a.EMAIL == Email).FirstOrDefault();
				if (account != null)
				{
					//Send email for reset password
					string resetCode = Guid.NewGuid().ToString();
					SendVerifycationLinkEmail(account.EMAIL, resetCode, "ResetPassword");
					account.RESETPASSWORDCODE = resetCode;

					db.Configuration.ValidateOnSaveEnabled = false;

					db.SaveChanges();
					message = "Link reset mật khẩu đã được gửi đến email của bạn.";
				}
				else
				{
					message = "Không tìm thấy tài khoản";
				}
			ViewBag.Message = message;
			return View();
		}

		public ActionResult ResetPassword(string id)
		{
				var account = db.ACCOUNTs.Where(a => a.RESETPASSWORDCODE == id).FirstOrDefault();
				if (account != null)
				{
					ResetPasswordModel model = new ResetPasswordModel();
					model.ResetCode = id;
					return View(model);
				}
				else
				{
					return HttpNotFound();
				}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult ResetPassword(ResetPasswordModel model)
		{
			var message = "";
			if (ModelState.IsValid)
			{
					var account = db.ACCOUNTs.Where(a => a.RESETPASSWORDCODE == model.ResetCode).FirstOrDefault();
					if (account != null)
					{
						account.PASSWORD = MD5.Hash(model.NewPassword);
						account.CONFIRMPASSWORD = MD5.Hash(model.ConfirmPassword);
                        account.RESETPASSWORDCODE = "";
						db.Configuration.ValidateOnSaveEnabled = false;
						db.SaveChanges();
						message = "Mật khẩu mới đã được cập nhật thành công";
					}
			}
			else
			{
				message = "Something invalid";
			}
			ViewBag.Message = message;
			return View(model);
		}
	}
}
