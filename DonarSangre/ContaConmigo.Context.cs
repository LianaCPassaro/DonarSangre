﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonarSangre
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContaConmigoEntities1 : DbContext
    {
        public ContaConmigoEntities1()
            : base("name=ContaConmigoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blood_Factor> Blood_Factor { get; set; }
        public virtual DbSet<Blood_Group> Blood_Group { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Donor> Donor { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Request_Donor> Request_Donor { get; set; }
    }
}
