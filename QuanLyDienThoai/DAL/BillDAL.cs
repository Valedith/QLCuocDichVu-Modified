using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net.Mail;
namespace QuanLyDienThoai.DAL
{
    class BillDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        BILL bill = new BILL();        
        public void setBill(string id, string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.ID_BILL = id;
            this.bill.ID_SIM = id_sim;
            this.bill.DATE_EXPORT = date_ex;
            this.bill.DATE_CUT = date_cut;
            this.bill.POSTAGE = postage;
            this.bill.FARE = fare;
            this.bill.STATUS = status;
        }
        public void setBill(string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.ID_SIM = id_sim;
            this.bill.DATE_EXPORT = date_ex;
            this.bill.DATE_CUT = date_cut;
            this.bill.POSTAGE = postage;
            this.bill.FARE = fare;
            this.bill.STATUS = status;
        }
        public void setBill(string id)
        {
            this.bill.ID_BILL = id;
        }
        public IEnumerable<BILL> GetAll()
        {
            List<BILL> bill = db.BILLs.ToList();
            return bill;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "B0";

            while (db.BILLs.Any(c => c.ID_BILL == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "B";
            }
            bill.ID_BILL = id_str + numeric_value.ToString();

            db.BILLs.Add(bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);

            db.BILLs.Remove(delete_bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);

            edited_bill.ID_SIM = bill.ID_SIM;
            edited_bill.DATE_EXPORT = bill.DATE_EXPORT;
            edited_bill.DATE_CUT = bill.DATE_CUT;
            edited_bill.POSTAGE = bill.POSTAGE;
            edited_bill.FARE = bill.FARE;
            edited_bill.STATUS = bill.STATUS;

            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Pay()
        {
            var edited_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);
            
            edited_bill.STATUS = true;

            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public IEnumerable<BILL> SearchByIDSIM(string id)
        {
            if (db.SIMs.Any(c => c.ID_SIM.Contains(id)))
            {
                List<BILL> result = db.BILLs.Where(c => c.ID_SIM.Contains(id)).ToList();
                return result;
            }
            return null;
        }

        // Function Gửi thông báo cước phí hàng tháng cho khách hàng khi tạo bill
        public bool SendBillByEmail(string toMail, string name_customer)
        {
            MailMessage mail = new MailMessage("min.lee397@gmail.com", toMail);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("min.lee397@gmail.com", "ypsnmvugzqedeqdw");
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Thông báo cước tháng - Dịch vụ cước điện thoại GTHD";
            mail.IsBodyHtml = true;

            string htmlBody = @"
            <div style='float:left;'>
		        <div style='float:left; width:100%; padding: 2% 2%; background-color:#4286f4; border:1px solid #4286f4; color:white; font-size: 30px; border-top-left-radius: 10px; border-top-right-radius:10px'>
			        Thanh toán cước điện thoại hàng tháng
		        </div>
		        <div style='float:left; width:100%; background-color:#ffffff; padding: 2% 2%; border:1px solid#4286f4;'>
			        <div style='float:left; width:100%; color:#cc0000; font-size:14px;'>Đây là email tự động từ hệ thống, vui lòng không phản hồi (reply) lại email này</div>
			        <div style='float:left; width:100%;'>
				        <p>
					        <strong>Kính gửi: " + name_customer + @"</strong>
					        <br /> 
					        Quý khách đã sử dụng dịch vụ cước điện thoại tới tháng 08 năm 2018, xin quý khách vui lòng đến dịch vụ của chúng tôi để thanh toán cước điện thoại từ tháng 07 năm 2018 đến tháng 08 năm 2018 để tiếp tục sử dụng dịch vụ cước điện thoại của chúng tôi.	
				        </p>
			        </div>
			        <div style='float:left; width:100%; padding: 2% 2%;'>
				        <table style='border:3px solid #cc0000; width: 90%;'>					       
					        <tr>
						        <td>Thời gian đã sử dụng:</td>
						        <td><span style='font-weight: bold;'><span style='font-weight: bold;'>" + bill.DATE_EXPORT.ToString() + @" - " + bill.DATE_CUT.ToString() + @"</span></td>
					        </tr>					        
					        <tr>
						        <td>Tiền thuê bao hàng tháng:</td>
						        <td><span style='font-weight: bold;'>" + bill.POSTAGE.ToString() + @" VNĐ</span></td>
					        </tr>
					        <tr>
						        <td>Tổng tiền:</td>
						        <td><span style='font-weight: bold;'>" + bill.FARE.ToString() + @"</span></td>
					        </tr>
				        </table>			
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff; font-weight: bold;'>
				        Nếu quý khách có thắc mắc vấn đề gì có thể liên hệ qua <span style='color: #cc0000'> 0764553313 </span>. hoặc có thể đi tới địa chỉ của dịch vụ chúng ta.
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff;'>
				        Thân trọng kính chào ! <br />
				        <strong>Dịch vụ cước điện thoại GTHD</strong>
			        </div>                    
		        </div>	
                <div style='float:left; width:100%; padding: 0% 2%; border:1px solid #4286f4; background-color:#4286f4;'>
			        <div style='float:left; width:3%;'>
				        <img width='20' height='20' src='https://lh3.googleusercontent.com/-Bl9Q-InF8O0/XAvv_Ihbg4I/AAAAAAAAB60/aniY2GoNQDgJkIFjj0zRyrzOfjSW2-gWwCL0BGAs/w530-d-h530-n-rw/call.png' />
			        </div>
			        <div style='float:left; width:50%; padding-top: 0.2%; color: white'>Thiết kế bởi minlee</div>
		        </div>	
	        </div>";

            mail.Body = htmlBody;
            client.Send(mail);
            return true;
        }
    }
}
