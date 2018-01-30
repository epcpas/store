using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Config
{
    public class ProductGroupConfig:EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupConfig()
        {
            this.HasMany(p => p.Child)
                .WithOptional(p => p.Parent);

            this.HasMany(p => p.Goods)
                .WithOptional(p => p.Groups);

            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Comment).IsMaxLength();
        }
    }
}
