﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaliSaha.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HalıSahaEntities : DbContext
    {
        public HalıSahaEntities()
            : base("name=HalıSahaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KiralanmışSahaTablo> KiralanmışSahaTablo { get; set; }
        public virtual DbSet<KullaniciGirisTablo> KullaniciGirisTablo { get; set; }
        public virtual DbSet<MevkiTablo> MevkiTablo { get; set; }
        public virtual DbSet<OyuncuTablo> OyuncuTablo { get; set; }
        public virtual DbSet<SahaTablo> SahaTablo { get; set; }
        public virtual DbSet<SemtTablo> SemtTablo { get; set; }
        public virtual DbSet<TakımTablo> TakımTablo { get; set; }
    }
}