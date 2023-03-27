using Learn1.Application.InterFaces.Context;
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
        
        public UsersController(IGetUsersServices getUsersServices, IGetRolesService getRolesServices)
        {
            _getUsersServices = getUsersServices;
            _getRolesServices= getRolesServices;
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
    }
}
