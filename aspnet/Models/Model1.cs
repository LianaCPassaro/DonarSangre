namespace aspnet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ASPModel")
        {
        }

        public  DbSet<Blood_Factor> Blood_Factor { get; set; }
        public  DbSet<Blood_Group> Blood_Group { get; set; }
        public  DbSet<City> City { get; set; }
        public  DbSet<Donor> Donor { get; set; }
        public  DbSet<Institution> Institution { get; set; }
        public  DbSet<Province> Province { get; set; }
        public  DbSet<Request_Donor> Request_Donor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blood_Factor>()
                .Property(e => e.Blood_Factor1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Blood_Factor>()
                .HasMany(e => e.Donor)
                .WithRequired(e => e.Blood_Factor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blood_Factor>()
                .HasMany(e => e.Request_Donor)
                .WithRequired(e => e.Blood_Factor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blood_Group>()
                .Property(e => e.Blood_Group1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Blood_Group>()
                .HasMany(e => e.Donor)
                .WithRequired(e => e.Blood_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blood_Group>()
                .HasMany(e => e.Request_Donor)
                .WithRequired(e => e.Blood_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Donor)
                .WithRequired(e => e.City)
                .HasForeignKey(e => new { e.CityId, e.ZipCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Institution)
                .WithRequired(e => e.City)
                .HasForeignKey(e => new { e.CityId, e.ZipCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Request_Donor)
                .WithRequired(e => e.City)
                .HasForeignKey(e => new { e.CityId, e.ZipCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Donor>()
                .Property(e => e.Name_Don)
                .IsUnicode(false);

            modelBuilder.Entity<Donor>()
                .Property(e => e.Last_Name_Don)
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .Property(e => e.InstitutionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .Property(e => e.InstitutionAdress)
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .HasMany(e => e.Request_Donor)
                .WithRequired(e => e.Institution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.ProvinceDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.City)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Province>()
                .HasOptional(e => e.Province1)
                .WithRequired(e => e.Province2);

            modelBuilder.Entity<Province>()
                .HasOptional(e => e.Province11)
                .WithRequired(e => e.Province3);

            modelBuilder.Entity<Request_Donor>()
                .Property(e => e.Name_Request_Don)
                .IsUnicode(false);

            modelBuilder.Entity<Request_Donor>()
                .Property(e => e.Last_Name_Request_Don)
                .IsUnicode(false);

            modelBuilder.Entity<Request_Donor>()
                .Property(e => e.Phone_Number)
                .IsFixedLength();
        }
    }
}
