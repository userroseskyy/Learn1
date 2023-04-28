using Learn1.Application.InterFaces.Context;
using Learn1.Common;
using Learn1.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace Learn1.Application.Services.Products.Queries.GetProductForSite
{
    public class GetProductForSiteService : IGetProductForSiteService
    {
        private readonly IDatabaseContext _context;
        public GetProductForSiteService(IDatabaseContext  context)
        {
            _context=context;
        }
        public ResultDto<ResultProductForSiteDto> Execute(int Page)
        {
            int totalRow = 0;
            var products = _context.Products
                .Include(p=> p.ProductImages)
                .ToPaged(Page, 5, out totalRow);
            Random rd= new Random();
            return new ResultDto<ResultProductForSiteDto>
            {
                Data=new ResultProductForSiteDto
                {
                    TotalRow= totalRow,
                    Products=products.Select(p => new ProductForSiteDto
                    {
                        Id=p.Id,
                        Star=rd.Next(1, 5),
                        Title=p.Name,
                        ImageSrc=p.ProductImages.FirstOrDefault().Src,
                        Price=p.Price,

                    }).ToList(),
                },
                isSuccess=true,



            };
        }

       
    }
}
