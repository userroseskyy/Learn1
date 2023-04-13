using Learn1.Application.Services.Products.Commands.AddNewCategory;
using Learn1.Application.Services.Products.Commands.AddNewProduct;
using Learn1.Application.Services.Products.Queries.Editcategory;
using Learn1.Application.Services.Products.Queries.GetCategories;
using Learn1.Application.Services.Products.Queries.RemoveCategory;

namespace Learn1.Application.InterFaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryServise AddNewCategoryServise { get; }
        IGetCategoriesService GetCategoriesService { get; }
        IRemoveCategory RemoveCategory { get; }
        IEditeCategoryService EditeCategoryService { get; }
        IAddNewProductService addNewProductService { get; }
    }
}
