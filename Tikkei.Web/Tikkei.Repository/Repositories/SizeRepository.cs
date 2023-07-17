using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface ISizeRepository : IBaseRespository<Size>
    {
    }
    public class SizeRepository : BaseRespository<Size>, ISizeRepository
    {
        public SizeRepository(TikkeiSystemModel context)
          : base(context)
        {

        }
    }
}
