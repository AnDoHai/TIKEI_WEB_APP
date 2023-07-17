using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Repository.Common;
using Tikkei.Repository.Repository;
using Tikkei.Service.Mapper;
using Tikkei.Service.Models.UserRoleModel;

namespace Tikkei.Service.Services
{
    public interface IUserRoleService
    {
        List<UserRoleModel> GetAll();
    }
    public class UserRoleService : IUserRoleService
    {

        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleService(IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork)
        {
            this._userRoleRepository = userRoleRepository;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get all data table User Role
        /// </summary>
        /// <returns>List UserRoleModel</returns>
        /// CreatedDate: 17/07/2023
        /// CreatedBy: dhan
        public List<UserRoleModel> GetAll()
        {
            var listUserRoles = new List<UserRoleModel>();
            try
            {
                var entities = _userRoleRepository.GetAllUserRole();

                if (entities.Count() > 0)
                {
                    listUserRoles = entities.MapToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listUserRoles;
        }
    }
}
