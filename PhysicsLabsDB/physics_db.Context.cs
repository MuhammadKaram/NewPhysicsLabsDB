﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhysicsLabsDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class physics_dbEntities : DbContext
    {
        public physics_dbEntities()
            : base("name=physics_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account_types> account_types { get; set; }
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<Device_Status> Device_Status { get; set; }
        public virtual DbSet<devices_tb> devices_tb { get; set; }
        public virtual DbSet<exp> exps { get; set; }
        public virtual DbSet<lab> labs { get; set; }
        public virtual DbSet<respon> respons { get; set; }
    }
}
