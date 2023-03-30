using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;

namespace Learn1.Application.Services.Users.Commands.RemoveUser
{
    public class RemoveUserService : IRemoveUserService
    {
        private readonly IDatabaseContext _Context;
        public RemoveUserService(IDatabaseContext Context)
        {
            _Context = Context;
        }
        public ResultDto Execute(long userId)
        {
            var user = _Context.Users.Find(userId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess=false,
                    Message="کاربر یافت نشد",

                };
            }
            user.RemoveTime = DateTime.Now;
            user.IsRemoved = true;
            _Context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess=true,
                Message="کاربر با موفقیت حذف شد"
            };
        }
    }
}
