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
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(exp => exp.Id);

            Property(exp => exp.Id).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(exp => exp.Intitule).HasColumnName("EXP_INTITULE").IsRequired().HasMaxLength(255);
            Property(exp => exp.Date).HasColumnName("EXP_DATE").IsRequired();

        }
    }
}
