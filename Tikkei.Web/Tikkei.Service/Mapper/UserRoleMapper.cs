using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Service.Models.UserRoleModel;

namespace Tikkei.Service.Mapper
{
    public static class UserRoleMapper
    {
        public static UserRoleModel MapToModel(this UserRole model)
        {
            return new UserRoleModel
            {

                UserRoleID = model.UserRoleID,
                UserRoleName = model.UserRoleName,
                CreatedDate = model.CreatedDate,
                CreatedBy = model.CreatedBy,
            };
        }

        public static UserRole MapToEntity(this UserRoleModel model)
        {
            return new UserRole
            {
                UserRoleName = model.UserRoleName,
                CreatedDate = model.CreatedDate,
                CreatedBy = model.CreatedBy,
            };
        }

        public static List<UserRoleModel> MapToList(this List<UserRole> entities)
        {
            return entities.Select(x => x.MapToModel()).ToList();
        }
    }
}
