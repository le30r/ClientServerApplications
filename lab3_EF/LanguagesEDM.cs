using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab3_EF
{
    public partial class LanguagesEDM : DbContext
    {
        public LanguagesEDM()
            : base("name=LanguagesEDM")
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Ethnical> Ethnical { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Countries>()
                .Property(e => e.Сontinent)
                .IsFixedLength();

            modelBuilder.Entity<Countries>()
                .Property(e => e.Capital)
                .IsFixedLength();

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Ethnical)
                .WithRequired(e => e.Countries)
                .HasForeignKey(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Languages>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Languages>()
                .Property(e => e.LanguageGroup)
                .IsFixedLength();

            modelBuilder.Entity<Languages>()
                .Property(e => e.SignSystem)
                .IsFixedLength();

            modelBuilder.Entity<Languages>()
                .HasMany(e => e.Ethnical)
                .WithRequired(e => e.Languages)
                .HasForeignKey(e => e.Language)
                .WillCascadeOnDelete(false);
        }
    }
}
