﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelaninaPrata.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBMelaninaEntities : DbContext
    {
        public DBMelaninaEntities()
            : base("name=DBMelaninaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cidade> cidades { get; set; }
        public virtual DbSet<grupos> grupos { get; set; }
        public virtual DbSet<pessoa> pessoas { get; set; }
        public virtual DbSet<produto> produtos { get; set; }
    }
}
