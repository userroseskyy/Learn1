using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Learn1.Domain.Entities.Products;

namespace Learn1.Application.Services.Products.Commands.AddNewCategory
{
    public class AddNewCategoryServise : IAddNewCategoryServise
    {
        private readonly IDatabaseContext _context;
        public AddNewCategoryServise(IDatabaseContext context)
        {
            _context=context;
        }
        public ResultDto Execute(long? ParentId, string Name)
        {
            if (string.IsNullOrEmpty(Name)) 
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message="نام دسته بندی را وارد نمائید",
                };
            }
           Category category =new Category()
           {
               Name = Name,
               ParentCategory=GetParent(ParentId),
           };
            _context.categories.Add(category);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message="دسته بندی با موفقیت اضافه شد",
            };
        }
        private Category GetParent(long? parentId)
        {
            return _context.categories.Find(parentId);
        }
    }
}
