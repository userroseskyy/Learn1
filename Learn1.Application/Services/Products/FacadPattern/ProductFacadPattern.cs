using Learn1.Application.InterFaces.Context;
using Learn1.Application.InterFaces.FacadPatterns;
using Learn1.Application.Services.Products.Commands.AddNewCategory;
using Learn1.Application.Services.Products.Commands.AddNewProduct;
using Learn1.Application.Services.Products.Queries.Editcategory;
using Learn1.Application.Services.Products.Queries.GetAllCategory;
using Learn1.Application.Services.Products.Queries.GetCategories;
using Learn1.Application.Services.Products.Queries.RemoveCategory;
using Microsoft.AspNetCore.Hosting;

namespace Learn1.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDatabaseContext _context;
        private readonly IHostingEnvironment _environment;

        public ProductFacad(IDatabaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;

            _environment = hostingEnvironment;
        }

        private AddNewCategoryServise _addNewCategory;


        public AddNewCategoryServise AddNewCategoryServise
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryServise(_context);
            }
        }
        private IGetCategoriesService _getCategoriesService;
        public IGetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }
        private IRemoveCategory _removeCategory;
        public IRemoveCategory RemoveCategory
        {
            get
            {
                return _removeCategory=_removeCategory ?? new RemoveCategory(_context);
            }
        }
        private IEditeCategoryService _editcategoryService;
        public IEditeCategoryService EditeCategoryService
        {
            get
            {
                return _editcategoryService=_editcategoryService?? new EditeCategoryService(_context);
            }
        }

        private AddNewProductService _addNewProductService;
        public AddNewProductService AddNewProductService
        {
            get
            {
                return _addNewProductService= _addNewProductService ?? new AddNewProductService(_context, _environment);
            }
        }

        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }
    }
}
