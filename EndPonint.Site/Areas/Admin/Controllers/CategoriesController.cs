using Learn1.Application.InterFaces.FacadPatterns;
using Learn1.Application.Services.Users.Commands.RemoveUser;
using Learn1.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EndPonint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductFacad _productFacad;

       
        public CategoriesController(IProductFacad productFacad,IRemoveUserService removeUserService)
        {
            _productFacad = productFacad;
           
        }
        public IActionResult Index(long? ParentId)
        {
            return View(_productFacad.GetCategoriesService.Execute(ParentId).Data);
        }
        [HttpGet]
        public IActionResult AddNewCategory(long? ParentId)
        {
            ViewBag.ParentId = ParentId;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCategory(long? ParentId,string Name)
        {
            var result =_productFacad.AddNewCategoryServise.Execute(ParentId, Name);
            return Json(result);
        }
        [HttpPost]
        public IActionResult Delete(long Id)
        {
            var result = _productFacad.RemoveCategory.Execute(Id);
            return Json(result);
        }

    }
}
