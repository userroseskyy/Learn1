using Learn1.Application.InterFaces.Context;
using Learn1.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;

namespace EndPonint.Site.Areas.Admin.Controllers
{  
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersServices _getUsersServices;
        public UsersController(IGetUsersServices getUsersServices)
        {
            _getUsersServices = getUsersServices;
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
            return View();
        }
    }
}
