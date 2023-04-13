using Learn1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Products.Commands.AddNewCategory
{
    public interface IAddNewCategoryServise
    {
        ResultDto Execute(long? ParentId, string Name);
    }

   
}
