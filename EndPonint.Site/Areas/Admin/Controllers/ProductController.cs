using Learn1.Application.InterFaces.FacadPatterns;
using Learn1.Application.Services.Products.Commands.AddNewProduct;
using Learn1.Application.Services.Products.FacadPattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPonint.Site.Areas.Admin.Controllers
{  
    [Area("Admin")]
    public class ProductController : Controller
    {
      
        private readonly IProductFacad _ProductFacad;

        public ProductController(IProductFacad ProductFacad)
        {
            _ProductFacad = ProductFacad;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
       
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_ProductFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(RequestAddNewProductDto request, List<AddNewProduct_Features> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_ProductFacad.AddNewProductService.Execute(request));
        }
    }
}
