using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Common.Queries.GetMenuItem
{
    public interface IGetMenuItemService
    {
        ResultDto<List<MenuItemDto>> Execute();
    }
    public class GetMenuItemService : IGetMenuItemService
    {
        private readonly IDatabaseContext _context;
        public GetMenuItemService(IDatabaseContext context)
        {
            _context=context;
        }
        public ResultDto<List<MenuItemDto>> Execute()
        {
            var category = _context.categories
                 .Include(p => p.SubCategories)
                   .Where(p => p.ParentCategoryId == null)
                 .ToList()
                 .Select(p => new MenuItemDto
                 {
                     CatId=p.Id,
                     Name=p.Name,
                     Child=p.SubCategories.ToList().Select(child => new MenuItemDto
                     {
                        CatId=child.Id,
                         Name= child.Name,

                     }).ToList(),
                 }).ToList();
            return new ResultDto<List<MenuItemDto>>()
            {
                Data= category,
                isSuccess=true,
            };
        }
    }
    public class MenuItemDto
    {
        public long CatId { get; set; }
        public string Name { get; set; }
        public List<MenuItemDto> Child { get; set; }

    }
    
}
