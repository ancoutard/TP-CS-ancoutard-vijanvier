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
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_STATUT");
            HasKey(s => s.Id);

            Property(s => s.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(255);

            HasMany(s => s.Offres).WithRequired(o => o.Statut).HasForeignKey(o => o.IdStatus);
        }
    }
}
