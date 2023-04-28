using Learn1.Application.InterFaces.FacadPatterns;
using Microsoft.AspNetCore.Mvc;

namespace EndPonint.Site.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productFacad;
        public ProductsController(IProductFacad  productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(int Page=1)
        {
            return View(_productFacad.GetProductForSiteService.Execute(Page).Data);
        }
    }
}
