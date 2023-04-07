using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Learn1.Domain.Entities;
using Learn1.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Products.Queries.RemoveCategory
{
    public interface IRemoveCategory
    {
        ResultDto Execute(long Id);
    }
    public class RemoveCategory : IRemoveCategory
    {
        private readonly IDatabaseContext _Context;
        public RemoveCategory(IDatabaseContext context)
        {
            _Context = context;
        }
        public ResultDto Execute(long Id)
        {
            var category = _Context.categories.Find(Id);
            if (category == null)
            {
                return new ResultDto
                {
                    IsSuccess=false,
                    Message="دسته بندی یافت نشد",

                };
            }
            category.RemoveTime = DateTime.Now;
            category.IsRemoved = true;
            _Context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess=true,
                Message="دسته بندی با موفقیت حذف شد"
            };
        }
    }
}
   


