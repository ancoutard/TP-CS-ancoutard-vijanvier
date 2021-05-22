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
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("APP_POSTULATION");
            HasKey(p => new { p.IdOffre, p.IdEmploye });

            Property(p => p.IdEmploye).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.IdOffre).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Date).HasColumnName("POS_DATE").IsRequired();
            Property(p => p.Statut).HasColumnName("POS_STATUT").IsRequired().HasMaxLength(255);


        }
    }
}
