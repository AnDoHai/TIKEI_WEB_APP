using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IBillDetailRepository : IBaseRespository<BillDetail>
    {
    }
    public class BillDetailRepository :  BaseRespository<BillDetail>, IBillDetailRepository
    {
         public BillDetailRepository(TIKKEI_SYSTEMEntities context)
            : base(context)
            {

            }

}
}
