using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Common.Queries.GetMenuItem
{
    public interface IGetMenuItemService
    {
        ResultDto<MenuItemDto> Execute();
    }
    public class GetMenuItemService : IGetMenuItemService
    {
        private readonly IDatabaseContext 
        public ResultDto<MenuItemDto> Execute()
        {
            throw new NotImplementedException();
        }
    }
    public class MenuItemDto
    {
        public long CatId { get; set; }
        public string Name { get; set; }
        public List<MenuItemDto> Child { get; set; }

    }
    public class MenuItemDto
    {
        public long CatId { get; set; }
        public string Name { get; set; }
        public List<MenuItemDto> Child  { get; set; }
    }
}
