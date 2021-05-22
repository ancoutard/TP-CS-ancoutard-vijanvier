using ClassLibrary1.Entities;
using ClassLibrary1.Initialize;
using ClassLibrary1.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("name=ProjectConnectionString")
        {
            Database.SetInitializer<ContextDB>(new ContextDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new OffreFluent());
            modelBuilder.Configurations.Add(new StatutFluent());
            modelBuilder.Configurations.Add(new PostulationFluent());
            modelBuilder.Configurations.Add(new EmployeFluent());
            modelBuilder.Configurations.Add(new FormationFluent());
            modelBuilder.Configurations.Add(new ExperienceFluent());
        }

        public DbSet<Offre> Offres { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
