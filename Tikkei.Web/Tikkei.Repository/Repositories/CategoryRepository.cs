using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface ICategoryRepository : IBaseRespository<Category>
    {
    }
    public class CategoryRepository : BaseRespository<Category>, ICategoryRepository
    {
        public CategoryRepository(TIKKEI_SYSTEMEntities context)
            : base(context)
        {

        }
    }
}
