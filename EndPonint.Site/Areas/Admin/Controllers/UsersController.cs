using Learn1.Application.InterFaces.Context;
using Learn1.Application.Services.Users.Commands.RegesterUser;
using Learn1.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPonint.Site.Areas.Admin.Controllers
{  
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersServices _getUsersServices;
        private readonly IGetRolesService _getRolesServices;
        private readonly IRegesterUserService _regesterUserService;

        public UsersController(IGetUsersServices getUsersServices, IGetRolesService getRolesServices, IRegesterUserService regesterUserService)
        {
            _getUsersServices = getUsersServices;
            _getRolesServices= getRolesServices;
            _regesterUserService = regesterUserService;
        }

     
        public IActionResult Index(string searchkey,int page=1)
        {
            return View(_getUsersServices.Execute(new RequestGetUserDto
            {
                Page=page,
                Searchkey=searchkey,
            }));
        }
        [HttpGet]
            public IActionResult Creat()
        {
            ViewBag.Roles=new SelectList(_getRolesServices.Execute().Data, "Id" ,"Name");
            return View();

        }
        [HttpPost]
        public IActionResult Creat(string Email,string FullName,long RoleId,string Password,string RePassword)
        {
            var result = _regesterUserService.Execute(new RequestRegesterUserDto
            {
                Email=Email,
                FullName=FullName,
                roles=new List<RolesInRegesterUserDto>()
                {
                    new RolesInRegesterUserDto
                    { 
                    Id=RoleId,
                    }
                },
                Password=Password,
                RePassword=RePassword,
                
            });
           
            return Json(result);
        }
    }
}
