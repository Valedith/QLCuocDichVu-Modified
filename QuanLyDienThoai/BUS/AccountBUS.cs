using QuanLyDienThoai.DAL;
using QuanLyDienThoai.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoaiEntity.Models;


namespace QuanLyDienThoai.BUS
{
    class AccountBUS
    {
        AccountDAL account_dal = new AccountDAL();
        public IEnumerable<ACCOUNT> GetAll()
        {
            return account_dal.GetAll();
        }

        public string Create(string email, string id_customer, string password,string confirm_password)
        {
            
            account_dal.setAccount(email, id_customer, password, confirm_password, "khachhang");

            if (email == "" || password == "" || confirm_password == "")
                return "Hãy điền đầy đủ thông tin !!!";
            if (account_dal.Check_Exists_IdCustomer() == true)
                return "Khách hàng này đã có tài khoản, xin hãy kiểm tra lại!!!";                
            if(account_dal.Check_Exists_Email() == true)            
                return "Email này đã có người sử dụng !!!";
            if (confirm_password != password)
                return "Mật khẩu nhập lại không khớp với mật khẩu đã nhập!!!";                 
            account_dal.Create();
            return "Đã thêm thành công tài khoản !!!";


        }

        public string Delete(string id_account)
        {
            account_dal.setAccount(id_account);
            account_dal.Delete();
            return "Đã xóa thành công tài khoản !!!";
        }

        public string getEmail_in_Account(string id_customer)
        {
            return account_dal.getEmail_in_Account(id_customer);
        }
        public IEnumerable<ACCOUNT> SearchBy_CustomerName(string name)
        {            
            return account_dal.SearchBy_CustomerName(name);
        }
    }
}
