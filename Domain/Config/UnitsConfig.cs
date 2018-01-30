using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Config
{
    public class UnitsConfig:EntityTypeConfiguration<Units>
    {
        public UnitsConfig()
        {
            Property(p => p.Name).HasMaxLength(100).IsRequired();
            Property(p => p.Comment).HasMaxLength(250);
        }
    }
}
