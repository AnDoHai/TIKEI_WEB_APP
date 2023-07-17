using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IColorRepository : IBaseRespository<Color>
    {
    }
    public class ColorRepository : BaseRespository<Color>, IColorRepository
    {
        public ColorRepository(TIKKEI_SYSTEMEntities context)
           : base(context)
        {

        }
    }
}
