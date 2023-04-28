using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Learn1.Domain.Entities.Products;
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
                    Category=GetCategory(product.Category),
                    Description=product.Description,
                    Displayed=product.Diplayed,
                    Id=product.Id,
                    Inventory=product.Inventory,
                    Name=product.Name,
                    Price=product.Price,
                    Feature=product.ProductFeatures.ToList().Select(p => new ProductDetaiFeatureDto
                    {
                        Id=p.Id,
                        DisplayName=p.DisplayName,
                        Value=p.Value,

                    }).ToList(),
                    Images=product.ProductImages.ToList().Select(p => new ProductDetailImageAdminDto
                    {
                        Id=p.Id,
                        Src=p.Src,
                    }).ToList(),
                },
                isSuccess=true,
                Message="",
            };
        }
        private string GetCategory(Category category)
        {
            string result = category.ParentCategory !=null ? $"{category.ParentCategory.Name} - " : "";
            return result += category.Name;
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
