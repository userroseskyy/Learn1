using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;

namespace Learn1.Application.Services.Users.Commands.EditeUser
{
    public class EditeUserService:IEditeUserService
    {
        private readonly IDatabaseContext _Context;
        public EditeUserService(IDatabaseContext Context)
        {
            _Context = Context;
        }

        public ResultDto Execute(RequestEdituserDto request)
        {
            var user = _Context.Users.Find(request.UserId);
            if (user==null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message="کاربر یافت نشد",
                };
            }
            user.FullName=request.Fullname;
            _Context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess=true,
                Message="ویرایش کاربر انجام شد",
            };

        }

    }
}
