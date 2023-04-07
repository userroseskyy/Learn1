using Learn1.Application.Services.Products.Commands.AddNewCategory;
using Learn1.Application.Services.Products.Queries.GetCategories;
using Learn1.Application.Services.Products.Queries.RemoveCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.InterFaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryServise AddNewCategoryServise { get; }
        IGetCategoriesService GetCategoriesService { get; }
        IRemoveCategory RemoveCategory { get;}
       
    }
}
