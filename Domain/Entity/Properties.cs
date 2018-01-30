using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool? IsDel { get; set; }
        public virtual PropertiesValue Value { get; set; }

    }
}
