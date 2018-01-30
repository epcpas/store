using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Goods
    {
        public Goods()
        {
            Properties = new List<PropertiesValue>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderPoint { get; set; }
        public string Comment { get; set; }

        public virtual ProductGroup Groups { get; set; }
        public virtual Units Units { get; set; }
        public virtual ICollection<PropertiesValue> Properties  { get; set; }
    }
}
