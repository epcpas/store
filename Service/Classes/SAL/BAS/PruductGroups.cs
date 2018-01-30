using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Service.Interface.SAL.BAS;

namespace Service.Classes.SAL.BAS
{
    public class PruductGroups : IProductGroup
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Domain.Entity.ProductGroup> _productGroups;

        public PruductGroups()
        {
            _unitOfWork = new DbEntity();
            _productGroups = _unitOfWork.Set<Domain.Entity.ProductGroup>();
        }

        public IList<Domain.Entity.ProductGroup> ListProductGroups()
        {
            return _productGroups.Where(con => con.IsDel == false && con.Parent == null).ToList();
        }

        public int Add(Domain.Entity.ProductGroup productGroup)
        {
            productGroup.IsDel = false;
            _productGroups.Add(productGroup);
            return _unitOfWork.SaveChanges();
        }

        public int Edit(Domain.Entity.ProductGroup productGroup)
        {
            var item = _productGroups.FirstOrDefault(con => con.Id == productGroup.Id);
            if (item == null) return -2;
            item.Name = productGroup.Name;
            item.Comment = productGroup.Comment;
            item.Parent = productGroup.Parent;
            return _unitOfWork.SaveChanges();
        }

        public int Delete(int id)
        {
            var item = _productGroups.FirstOrDefault(con => con.Id == id);
            if (item == null) return -2;
            item.IsDel = true;
            return _unitOfWork.SaveChanges();
        }

    }
}
