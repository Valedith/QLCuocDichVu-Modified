using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDienThoaiEntity.ViewModels
{
    public class BillDetails
    {
        public BillDetails() { }
        public BillDetails(string ID_SIM,DateTime? DATE_EXPORT,DateTime? DATE_CUT,int? POSTAGE,int? MINUTEUSED,int? FARE,bool? STATUS)
        {
            this.ID_SIM = ID_SIM;
            this.DATE_EXPORT = DATE_EXPORT;
            this.DATE_CUT = DATE_CUT;
            this.POSTAGE = POSTAGE;
            this.MINUTEUSED = MINUTEUSED;
            this.FARE = FARE;
            this.STATUS = STATUS;
        }
        public string ID_SIM { get; set; }
        public Nullable<System.DateTime> DATE_EXPORT { get; set; }
        public Nullable<System.DateTime> DATE_CUT { get; set; }
        public Nullable<int> POSTAGE { get; set; }
        public Nullable<int> MINUTEUSED { get; set; }
        public Nullable<int> FARE { get; set; }
        public Nullable<bool> STATUS { get; set; }
    }
}