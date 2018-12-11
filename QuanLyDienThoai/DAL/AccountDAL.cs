using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoaiEntity.Models;


namespace QuanLyDienThoai.DAL
{
    class AccountDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        ACCOUNT account = new ACCOUNT();

        public void setAccount(string id_account)
        {
            this.account.ID_ACCOUNT = id_account;
        }

        public void setAccount(string email, string id_customer, string password, string confirm_password, string type_account)
        {            
            this.account.EMAIL = email;
            this.account.ID_CUSTOMER = id_customer;
            this.account.PASSWORD = password;
            this.account.TYPE_ACCOUNT = type_account;
            this.account.CONFIRMPASSWORD = confirm_password;
        }        
        
        public IEnumerable<ACCOUNT> GetAll()
        {
            List<ACCOUNT> account = db.ACCOUNTs.Where(s => s.TYPE_ACCOUNT == "khachhang").ToList();
            return account;
        }
        public IEnumerable<ACCOUNT> SearchBy_CustomerName(string name)
        {
            if (db.ACCOUNTs.Any(c => c.CUSTOMER.NAME.Contains(name) && c.TYPE_ACCOUNT == "khachhang"))
            {
                List<ACCOUNT> result = db.ACCOUNTs.Where(c => c.CUSTOMER.NAME.Contains(name) && c.TYPE_ACCOUNT=="khachhang").ToList();
                return result;
            }
            return null;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "ACC0";

            while (db.ACCOUNTs.Any(c => c.ID_ACCOUNT == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "ACC";
            }
            account.ID_ACCOUNT = id_str + numeric_value.ToString();

            db.ACCOUNTs.Add(account);
            db.SaveChanges();

            db.Entry(account).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_account = db.ACCOUNTs.Where(p => p.ID_ACCOUNT == account.ID_ACCOUNT).Select(p => p).FirstOrDefault();
            edited_account.ID_CUSTOMER = account.ID_CUSTOMER;
            edited_account.EMAIL = account.EMAIL;
            edited_account.PASSWORD = account.PASSWORD;
            edited_account.TYPE_ACCOUNT = account.TYPE_ACCOUNT;
            db.SaveChanges();

            db.Entry(account).State = EntityState.Detached;            
        }

        public void Delete()
        {
            var delete_account = db.ACCOUNTs.First(p => p.ID_ACCOUNT == account.ID_ACCOUNT);

            db.ACCOUNTs.Remove(delete_account);
            db.SaveChanges();
            db.Entry(account).State = EntityState.Detached;
        }

        public bool Check_Exists_IdCustomer()
        {
            if (db.ACCOUNTs.Any(c => c.ID_CUSTOMER.Equals(account.ID_CUSTOMER)))
                return true;
            return false;
        }
        public bool Check_Exists_Email()
        {
            if (db.ACCOUNTs.Any(c => c.EMAIL.Equals(account.EMAIL)))
                return true;
            return false;
        }

        public List<ACCOUNT> SearchBy_IdAccount()
        {           
            if (db.ACCOUNTs.Any(c => c.ID_ACCOUNT.Contains(account.ID_ACCOUNT)))
            {
                List<ACCOUNT> result = db.ACCOUNTs.Where(c => c.ID_ACCOUNT.Contains(account.ID_ACCOUNT)).ToList();
                return result;
            }
            return null;
        }

        public string getEmail_in_Account(string id_customer)
        {
            return (from h in db.ACCOUNTs where h.ID_CUSTOMER.Equals(id_customer) select h.EMAIL).FirstOrDefault();
        }
    }
}
