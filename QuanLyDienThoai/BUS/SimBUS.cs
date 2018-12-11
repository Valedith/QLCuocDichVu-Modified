using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoaiEntity.Models;


namespace QuanLyDienThoai.BUS
{
    class SimBUS
    {
        SimDAL sim_dal = new SimDAL();
        public IEnumerable<SIM> GetAll()
        {
            return sim_dal.GetAll();
        }
        public string Create(string id_cus,int phonenumber, bool status)
        {
            sim_dal.setSim(id_cus, phonenumber, status);
            if (phonenumber.ToString().Length <= 12 && phonenumber.ToString().Length >= 8 || !checkPhoneNumber())
            {
                sim_dal.Create();
                return "Thêm sim thành công !";
            }
            else            
                return "Không thể thêm, Số điện thoại không hợp lệ";
        }

        public string Delete(string id)
        {
                sim_dal.setSim(id);
                sim_dal.Delete();
                    return "Xóa thành công !";
        }
        public bool checkPhoneNumber()
        {
            return sim_dal.checkPhoneNumber();
        }
        public string Update(string id,string id_cus, int phonenumber, bool status)
        {
            sim_dal.setSim(id, id_cus, phonenumber, status);
            if (phonenumber.ToString().Length <= 12 && phonenumber.ToString().Length >= 8 )
            {
                sim_dal.Update();
                return "Đã thay đổi thành công !";
            }            
            else
                return "Không thể sửa, Số điện thoại không hợp lệ";

        }

        public void Update_ID_Customer(string id_sim, string id_customer, bool status)
        {            
            sim_dal.setSim(id_sim, id_customer, status);
            sim_dal.Update_ID_Customer();                   
        }
     
        public List<SIM> SearchById_Sim(string id_sim)
        {
            return sim_dal.SearchById_Sim(id_sim);
        }
        public List<SIM> SearchBy_CustomerName(string name)
        {
            return sim_dal.SearchBy_CustomerName(name);
        }

        public string getIDcustomer_in_Sim(string id_sim)
        {
            sim_dal.setSim(id_sim);
            return sim_dal.getIDcustomer_in_Sim();
        }

        public string lockSim(string id)
        {
            sim_dal.setSim(id);
            sim_dal.lockSim();
            return "Khóa SIM thành cống !";
        }
        public bool checkifLocked(string id)
        {
            sim_dal.setSim(id);
            return sim_dal.checkifLocked();
        }
    }
}
