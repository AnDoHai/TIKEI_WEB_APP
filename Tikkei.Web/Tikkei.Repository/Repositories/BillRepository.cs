using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IBillRepository : IBaseRespository<Bill>
    {
    }
    public class BillRepository : BaseRespository<Bill>, IBillRepository
    {
        public BillRepository(TIKKEI_SYSTEMEntities context)
            : base(context)
        {

        }
    }
}
