using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Mapping
{
    public class EmployeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeFluent() 
        {
            ToTable("APP_EMPLOYE");
            HasKey(e => e.Id);

            Property(e => e.Id).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(255);
            Property(e => e.Prenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(255); ;
            Property(e => e.DateNaissance).HasColumnName("EMP_DATENAISSANCE").IsRequired();
            Property(e => e.Anciennete).HasColumnName("EMP_ANCIENNETE").IsRequired();
            Property(e => e.Biographie).HasColumnName("EMP_BIOGRAPHIE").IsRequired().HasMaxLength(1000); ;


            HasMany(e => e.Postulations).WithRequired(p => p.Employe).HasForeignKey(p => p.IdEmploye);
            HasMany(e => e.Formations).WithRequired(f => f.Employe).HasForeignKey(f => f.IdEmploye);
            HasMany(e => e.Experiences).WithRequired(exp => exp.Employe).HasForeignKey(exp => exp.IdEmploye);

        }
    }
}
