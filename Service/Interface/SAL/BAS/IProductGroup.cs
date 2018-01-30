using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Service.Interface.SAL.BAS
{
    public interface IProductGroup
    {
        IList<ProductGroup> ListProductGroups();
        int Add(ProductGroup productGroup);
        int Edit(ProductGroup productGroup);
        int Delete(int id);

    }
}
