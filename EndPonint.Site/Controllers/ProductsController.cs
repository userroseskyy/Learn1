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
        public IActionResult Index(long? CatId=null, int Page=1)
        {
            return View(_productFacad.GetProductForSiteService.Execute(Page,CatId).Data);
        } public IActionResult Detail(long Id)
        
        {
            return View(_productFacad.GetProductDetailForSiteService.Execute(Id).Data);
        }
        
    }
}
