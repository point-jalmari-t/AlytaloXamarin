﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlytaloMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KurssitehtavaEntities1 : DbContext
    {
        public KurssitehtavaEntities1()
            : base("name=KurssitehtavaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sauna> Sauna { get; set; }
        public virtual DbSet<Termostaatti> Termostaatti { get; set; }
        public virtual DbSet<Valot> Valot { get; set; }
    }
}
