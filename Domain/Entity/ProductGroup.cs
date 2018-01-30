using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public  class ProductGroup
    {

        public ProductGroup()
        {
            Goods = new List<Goods>();
            Child=new List<ProductGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool? IsDel { get; set; }
        public virtual ICollection<ProductGroup> Child { get; set; } 
        public virtual ProductGroup Parent { get; set; }
        public virtual ICollection<Goods> Goods { get; set; } 
    }
}
