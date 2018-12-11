using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoaiEntity.Models;


namespace QuanLyDienThoai.BUS
{
    class CustomerBUS
    {
        CustomerDAL customer_dal = new CustomerDAL();
        public IEnumerable<CUSTOMER> GetAll()
        {
            return customer_dal.GetAll();
        }
        public string Create(string name, int identity,string job,string position,string address)
        {
            customer_dal.setCustomer(name, identity, job, position, address);
            if (!checkExistCustomer())
            {
                customer_dal.Create();
                return "Thêm khách hàng thành công !";
            }
            else
                return "Thông tin khách hàng bị trùng";
        }

        public string Delete(string id)
        {
            customer_dal.setCustomer(id);
            customer_dal.Delete();
            return "Xóa thông tin khách hàng thành công !";
        }

        public string Update(string id,string name, int identity, string job, string position, string address)
        {
            customer_dal.setCustomer(id, name, identity, job, position, address);
            if (!checkExistCustomer())
            {
                customer_dal.Update();
                return "Sửa thông tin khách hàng thành công !";
            }
            else
                return "Thông tin khách hàng bị trùng !";
        }
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            return customer_dal.SearchByName(name);
        }
        public List<CUSTOMER> SearchById_Customer(string id_customer)
        {
            return customer_dal.SearchById_Customer(id_customer);
        }

        public bool checkExistCustomer()
        {
            return customer_dal.checkExistCustomer();
        }
        public string getName_in_Customer(string id_customer)
        {
            return customer_dal.getName_in_Customer(id_customer);
        }
    }
}
