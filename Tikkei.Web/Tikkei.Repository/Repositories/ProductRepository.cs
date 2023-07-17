using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IProductRepository : IBaseRespository<Product>
    {
    }
    public class ProductRepository : BaseRespository<Product>, IProductRepository
    {
        public ProductRepository(TikkeiSystemModel context)
          : base(context)
        {

        }
    }
}
