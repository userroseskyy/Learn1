using Learn1.Application.InterFaces.Context;
using Learn1.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;

namespace EndPonint.Site.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsersServices _getUsersServices;
        public UsersController(IGetUsersServices getUsersServices)
        {
            _getUsersServices = getUsersServices;
        }

        [Area("Admin")]
        public IActionResult Index(string searchkey,int page=1)
        {
            return View(_getUsersServices.Execute(new RequestGetUserDto
            {
                Page=page,
                Searchkey=searchkey,
            }));
        }
    }
}
