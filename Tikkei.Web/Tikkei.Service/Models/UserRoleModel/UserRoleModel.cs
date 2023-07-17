using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikkei.Service.Models.UserRoleModel
{
    public class UserRoleModel
    {
        public int UserRoleID { get; set; }
        public string UserRoleName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
