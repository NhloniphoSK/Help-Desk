﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MacroComm_HelpDesk
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MacrocommEntities : DbContext
    {
        public MacrocommEntities()
            : base("name=MacrocommEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblLogFault> tblLogFaults { get; set; }
        public virtual DbSet<tblLogOther> tblLogOthers { get; set; }
        public virtual DbSet<tblRegistration> tblRegistrations { get; set; }
        public virtual DbSet<tblViewLog> tblViewLogs { get; set; }
    }
}
