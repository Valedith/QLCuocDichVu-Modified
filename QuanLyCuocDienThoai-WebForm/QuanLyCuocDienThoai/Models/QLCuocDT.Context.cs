﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuocDienThoai.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCuocDTEntities : DbContext
    {
        public QLCuocDTEntities()
            : base("name=QLCuocDTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<CONTRACT> CONTRACTs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<DETAIL> DETAILs { get; set; }
        public virtual DbSet<FARE> FAREs { get; set; }
        public virtual DbSet<SIM> SIMs { get; set; }
    }
}