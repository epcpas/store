using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Config
{
    public class PropertiesValueConfig:EntityTypeConfiguration<PropertiesValue>
    {
        public PropertiesValueConfig()
        {
            this.HasRequired(p => p.Goods).WithMany(p => p.Properties).WillCascadeOnDelete();

            Property(p => p.PropValues).IsRequired();
        }
    }
}
