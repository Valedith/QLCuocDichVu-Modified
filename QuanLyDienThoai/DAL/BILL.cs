
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QuanLyDienThoai.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class BILL
{

    public string ID_BILL { get; set; }

    public string ID_SIM { get; set; }

    public Nullable<System.DateTime> DATE_EXPORT { get; set; }

    public Nullable<System.DateTime> DATE_CUT { get; set; }

    public Nullable<int> POSTAGE { get; set; }

    public Nullable<int> FARE { get; set; }

    public Nullable<bool> STATUS { get; set; }



    public virtual SIM SIM { get; set; }

}

}