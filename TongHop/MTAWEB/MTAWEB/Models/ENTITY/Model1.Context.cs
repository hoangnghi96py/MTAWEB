﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MTAWEBEntities : DbContext
    {
        public MTAWEBEntities()
            : base("name=MTAWEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<CATEGOTY> CATEGOTies { get; set; }
        public virtual DbSet<NEWS> NEWS { get; set; }
        public virtual DbSet<PICTURE> PICTUREs { get; set; }
        public virtual DbSet<SUBCATEGOTY> SUBCATEGOTies { get; set; }
        public virtual DbSet<UNITCATEGOTY> UNITCATEGOTies { get; set; }
    }
}
