using System;
using Elearning.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.Unit;
using Elearning.Core.Contracts.User;
using Elearning.Database.Models;
using Elearning.Web.Filters;
using Elearning.Web.Models.Users;
using Serilog;
using Functions = Elearning.Core.Contants.Functions;

namespace Elearning.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitRepository _unitRepository;


        public HomeController(IUserRepository userRepository, IUnitRepository unitRepository)
        {
            _userRepository = userRepository;
            _unitRepository = unitRepository;
        }

        [Route("index.html")]
        [AuthorizeUser(Module = Functions.Home, Permission = PermissionConstant.VIEW)]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
