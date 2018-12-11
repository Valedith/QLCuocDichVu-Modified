using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoaiEntity.Models;


namespace QuanLyDienThoai.DAL
{
    public class SimDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        SIM sim = new SIM();        
        public void setSim(string id)
        {
            this.sim.ID_SIM = id;
        }
        public void setSim(string id,string cus_id,int phonenumber,bool status)
        {
            this.sim.ID_SIM = id;
            this.sim.PHONENUMBER = phonenumber;
            this.sim.ID_CUSTOMER = cus_id;
            this.sim.STATUS = status;
        }
        public void setSim(string cus_id,int phonenumber, bool status)
        {
            this.sim.ID_CUSTOMER = cus_id;
            this.sim.PHONENUMBER = phonenumber;
            this.sim.STATUS = status;
        }

        public void setSim(string id_sim, string id_customer, bool status)
        {
            this.sim.ID_SIM = id_sim;
            this.sim.ID_CUSTOMER = id_customer;
            this.sim.STATUS = status;
        }
        public IEnumerable<SIM> GetAll()
        {
            List<SIM> sim = db.SIMs.ToList();
            return sim;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "S0";

            while (db.SIMs.Any(c => c.ID_SIM == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "S";
            }
            sim.ID_SIM = id_str + numeric_value.ToString();


            db.SIMs.Add(sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            db.SIMs.Remove(delete_sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            edited_sim.ID_CUSTOMER = sim.ID_CUSTOMER;
            edited_sim.PHONENUMBER = sim.PHONENUMBER;
            edited_sim.STATUS = sim.STATUS;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Update_ID_Customer()
        {
            var edited_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);
            edited_sim.STATUS = this.sim.STATUS;
            edited_sim.ID_CUSTOMER = this.sim.ID_CUSTOMER;

            db.SaveChanges();
            db.Entry(sim).State = EntityState.Detached;
        }

        public List<SIM> SearchById_Sim(string id_sim)
        {
            if (db.SIMs.Any(c => c.ID_SIM.Contains(id_sim)))
            {
                List<SIM> result = db.SIMs.Where(c => c.ID_SIM.Contains(id_sim)).ToList();
                return result;
            }
            return null;
        }
        public List<SIM> SearchBy_CustomerName(string name)
        {
            if (db.SIMs.Any(c => c.CUSTOMER.NAME.Contains(name)))
            {
                List<SIM> result = db.SIMs.Where(c => c.CUSTOMER.NAME.Contains(name)).ToList();
                return result;
            }
            return null;
        }
        public string getIDcustomer_in_Sim()
        {
            return (from h in db.SIMs where h.ID_SIM.Equals(sim.ID_SIM) select h.ID_CUSTOMER).FirstOrDefault();
        }

        public bool checkPhoneNumber()
        {
            return db.SIMs.Any(c => c.PHONENUMBER == sim.PHONENUMBER);
        }
        public bool checkifLocked()
        {
            var check = (from h in db.SIMs
                         where h.ID_SIM.Equals(sim.ID_SIM)
                         select h.STATUS).SingleOrDefault();
            return (bool)check;
        }
        public void lockSim()
        {
            var lock_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            lock_sim.STATUS = false;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;

        }
    }
}
