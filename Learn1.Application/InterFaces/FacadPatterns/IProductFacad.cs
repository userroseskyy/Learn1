using Learn1.Application.Services.Products.Commands.AddNewCategory;
using Learn1.Application.Services.Products.Commands.AddNewProduct;
using Learn1.Application.Services.Products.Queries.Editcategory;
using Learn1.Application.Services.Products.Queries.GetAllCategory;
using Learn1.Application.Services.Products.Queries.GetCategories;
using Learn1.Application.Services.Products.Queries.GetProductDetailForAdmin;
using Learn1.Application.Services.Products.Queries.GetProductForAdmin;
using Learn1.Application.Services.Products.Queries.RemoveCategory;

namespace Learn1.Application.InterFaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryServise AddNewCategoryServise { get; }
        IGetCategoriesService GetCategoriesService { get; }
        IRemoveCategory RemoveCategory { get; }
        IEditeCategoryService EditeCategoryService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        /// <summary>
        /// دریافت لیست محصولات
        /// </summary>
        IGetProductForAdminService GetProductForAdminService { get; }

        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
    }
}
