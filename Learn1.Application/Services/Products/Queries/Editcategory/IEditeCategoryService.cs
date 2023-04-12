using Learn1.Application.InterFaces.Context;
using Learn1.Application.Services.Users.Commands.EditeUser;
using Learn1.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Products.Queries.Editcategory
{
    public interface IEditeCategoryService
    {
        ResultDto Execute(RequestEdituserDto request);
    }
    public class EditeCategoryService : IEditeCategoryService
    {
        private  IDatabaseContext _Context;
        public EditeCategoryService(IDatabaseContext context)
        {
            _Context = context;
        }
        public ResultDto Execute(RequestEdituserDto request)
        {
            var user = _Context.categories.Find(request.UserId);
            if (user==null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message="دسته بندی یافت نشد",
                };
            }
            user.Name=request.Fullname;
            _Context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess=true,
                Message="ویرایش دسته بندی انجام شد",
            };

        }
    }
}
