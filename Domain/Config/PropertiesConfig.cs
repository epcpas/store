using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Config
{
    public class PropertiesConfig:EntityTypeConfiguration<Properties>
    {
        public PropertiesConfig()
        {
            this.HasOptional(p => p.Value).WithRequired(p => p.Properties).WillCascadeOnDelete();

            Property(p => p.Name).HasMaxLength(150).IsRequired();
            Property(p => p.Comment).HasMaxLength(250);
        }
    }
}
