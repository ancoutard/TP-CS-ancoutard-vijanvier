using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.Mapping
{
    public class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_OFFRE");
            HasKey(o => o.Id);

            Property(o => o.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Intitule).HasColumnName("OFF_INTITULE").IsRequired().HasMaxLength(255);
            Property(o => o.Date).HasColumnName("OFF_DATE").IsRequired();
            Property(o => o.Salaire).HasColumnName("OFF_SALAIRE").IsRequired();
            Property(o => o.Description).HasColumnName("OFF_DESCRIPTION").IsRequired();
            Property(o => o.IdStatus).HasColumnName("STA_ID").IsRequired();
            Property(o => o.Responsable).HasColumnName("OFF_RESPONSABLE").IsRequired().HasMaxLength(50);

            HasMany(o => o.Postulations).WithRequired(p => p.Offre).HasForeignKey(p => p.IdOffre);

        }

    }
}
