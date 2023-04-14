using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Products.Queries.GetAllCategory
{
    public interface IGetAllCategoriesService
    {
        ResultDto<List<AllCategoriesDto>> Execute();
    }


    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly IDatabaseContext _context;

        public GetAllCategoriesService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<AllCategoriesDto>> Execute()
        {
            var categories = _context
                .categories
                .Include(p => p.ParentCategory)
                .Where(p => p.ParentCategoryId != null)
                .ToList()
                .Select(p => new AllCategoriesDto
                {
                    Id = p.Id,
                    Name = $"{p.ParentCategory.Name} - {p.Name}",
                }
                ).ToList();

            return new ResultDto<List<AllCategoriesDto>>
            {
                Data = categories,
                isSuccess = false,
                Message = "",
            };
        }
    }

    public class AllCategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

}
