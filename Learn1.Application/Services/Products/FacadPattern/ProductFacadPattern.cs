using Learn1.Application.InterFaces.Context;
using Learn1.Application.InterFaces.FacadPatterns;
using Learn1.Application.Services.Products.Commands.AddNewCategory;
using Learn1.Application.Services.Products.Queries.GetCategories;

namespace Learn1.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDatabaseContext _context;
        public ProductFacad(IDatabaseContext context)
        {
            _context = context;
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

    }
}
