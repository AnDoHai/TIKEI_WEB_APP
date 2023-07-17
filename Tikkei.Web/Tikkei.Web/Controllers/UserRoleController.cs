using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tikkei.Service.Services;

namespace Tikkei.Web.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            this._userRoleService = userRoleService;
        }
        // GET: UserRole
        public ActionResult Index()
        {
            var check = _userRoleService.GetAll();
            return View();
        }

        public ActionResult GetAll()
        {
            return View();
        }
    }
}