using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class PropertiesValue
    {
        public int Id { get; set; }
        public string PropValues { get; set; }
        public virtual Properties Properties { get; set; }
        public virtual Goods Goods { get; set; }
    }
}
