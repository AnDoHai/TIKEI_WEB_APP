using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IImageRepository : IBaseRespository<Image>
    {
    }
    public class ImageRepository : BaseRespository<Image>, IImageRepository
    {
        public ImageRepository(TikkeiSystemModel context)
          : base(context)
        {

        }
    }
}
