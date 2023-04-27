using Learn1.Application.InterFaces.Context;
using Learn1.Common;
using Learn1.Common.Dto;
using Learn1.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Products.Queries.GetProductForAdmin
{
    public interface IGetProductForAdminService
    {
        ResultDto<ProductForAdminDto> Execute(int Page = 1, int PageSize = 20);
    }
    public class GETProductForAdminService : IGetProductForAdminService
    {
        private readonly IDatabaseContext _context;

        public GETProductForAdminService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<ProductForAdminDto> Execute(int Page = 1, int PageSize = 20)
        {
            int rowCount=0;
            var products = _context.Products
                .Include(p => p.Category)
                .ToPaged(Page, PageSize, out rowCount)
                .Select(p => new ProductForAdminList_Dto
                {
                    Id= p.Id,
                    Name= p.Name,
                    Category=p.Category.Name,
                    Discription=p.Description,
                    Displayed=p.Diplayed,
                    Inventory=p.Inventory,
                    Price=p.Price,
                }).ToList();
            return new ResultDto<ProductForAdminDto>()
            {
                Data =new ProductForAdminDto()
                {
                    Products = products,
                    CurentPage= Page,
                    PageSize= PageSize/3,
                    RowCount= rowCount
                },
                isSuccess=true,
                Message="",
            };
            
        }
    }






    public class ProductForAdminDto
    {
        public int RowCount { get; set; }
        public int CurentPage { get; set; }
        public int PageSize { get; set; }
       
        public List<ProductForAdminList_Dto> Products { get; set; }

    }
    public class ProductForAdminList_Dto
    {
        public long Id { get; set;}
        public string Name { get; set;}
        public string Category { get; set;}
        public string Brand { get; set;}
        public string Discription { get; set;}
        public int Price { get; set;}
        public int Inventory { get; set;}
        public bool Displayed { get; set;}


    }

}
