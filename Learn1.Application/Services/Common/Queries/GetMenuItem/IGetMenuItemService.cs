using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Common.Queries.GetMenuItem
{
    public interface IGetMenuItemService
    {
    }
    public class MenuItemDto
    {
        public long CatId { get; set; }
        public string Name { get; set; }
        public List<MenuItemDto> Child { get; set; }

    }
}
