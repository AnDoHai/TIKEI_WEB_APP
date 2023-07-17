using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IProductDetailRepository : IBaseRespository<ProductDetail>
    {
    }
    public class ProductDetailRepository : BaseRespository<ProductDetail>, IProductDetailRepository
    {
        public ProductDetailRepository(TikkeiSystemModel context)
          : base(context)
        {

        }
    }
}
