using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Config
{
    public class GoodsConfig:EntityTypeConfiguration<Goods>
    {
        public GoodsConfig()
        {
           
            

            Property(p => p.Code).HasMaxLength(50).IsRequired();
            Property(p => p.Name).HasMaxLength(200).IsRequired();
            Property(p => p.Comment).IsMaxLength();
        }
    }
}
