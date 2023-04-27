using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace Learn1.Application.Services.Products.Queries.GetProductDetailForAdmin
{
    public interface IGetProductDetailForAdminService
    {
        ResultDto<ProductDetailForAdminDto> Execute(long Id);
    }
    public class GetProductDetailForAdminService : IGetProductDetailForAdminService
    {
        private readonly IDatabaseContext _context;
        public GetProductDetailForAdminService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductDetailForAdminDto> Execute(long Id)
        {
            var product = _context.Products
                .Include(p => p.Category)
                .ThenInclude(p => p.ParentCategory)
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductImages)
                .Where(p => p.Id == Id)
                .FirstOrDefault();
            return new ResultDto<ProductDetailForAdminDto>()
            {
                Data=new ProductDetailForAdminDto()
                {
                    Brand =product.Brand,
                    Category=GetCategories(product.Category),
                    Description=product.Description,

                }
            }
        }
    }
    public class ProductDetailForAdminDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }
        public List<ProductDetaiFeatureDto> Feature { get; set; }
        public List<ProductDetailImageAdminDto> Images { get; set; }


    }
    public class ProductDetailImageAdminDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
    }
    public class ProductDetaiFeatureDto
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }



}
