using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Common;

namespace Tikkei.Repository.Repository
{
    public interface IUserRoleRepository : IBaseRespository<UserRole>
    {
        List<UserRole> GetAllUserRole();
    }
    public class UserRoleRepository : BaseRespository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(TikkeiSystemModel context)
          : base(context)
        {

        }

        public List<UserRole> GetAllUserRole()
        {
            return Dbset.AsQueryable().ToList();
        }
    }
}
