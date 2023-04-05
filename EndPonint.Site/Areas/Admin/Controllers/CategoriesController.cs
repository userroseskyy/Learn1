using Learn1.Application.InterFaces.FacadPatterns;
using Microsoft.AspNetCore.Mvc;

namespace EndPonint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductFacad _productFacad;
        public CategoriesController(IProductFacad productFacad)
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
    }
}
