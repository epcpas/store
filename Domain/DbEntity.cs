using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Config;
using Domain.Entity;

namespace Domain
{
    public class DbEntity:DbContext,IUnitOfWork
    {
        public DbEntity():base("StoreDb")
        {}

        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<PropertiesValue> PropertiesValues { get; set; }
        public DbSet<Goods> Goods { get; set; }


        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductGroupConfig());
            modelBuilder.Configurations.Add(new UnitsConfig());
            modelBuilder.Configurations.Add(new PropertiesConfig());
            modelBuilder.Configurations.Add(new PropertiesValueConfig());
            modelBuilder.Configurations.Add(new GoodsConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
