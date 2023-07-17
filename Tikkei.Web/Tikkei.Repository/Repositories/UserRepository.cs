using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repositories
{
    public interface IUserRepository : IBaseRespository<User>
    {
    }
    public class UserRepository : BaseRespository<User>, IUserRepository
    {
        public UserRepository(TikkeiSystemModel context)
          : base(context)
        {

        }
    }
}
