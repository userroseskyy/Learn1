using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;

namespace Learn1.Application.Services.Users.Commands.UserStatusChenge
{
    public class UserStatusChengeServic : IUserStatusChengeServic
    {
        private readonly IDatabaseContext _context;
        public UserStatusChengeServic(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Excute(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
               return new ResultDto { 
               IsSuccess = false,
               Message = "کاربر یافت نشد!",
               };
            }
            user.IsActive=!user.IsActive;
            _context.SaveChanges();
            string userstate = user.IsActive==true ? "فعال" : "غیر فعال";
            return new ResultDto
            {
                IsSuccess=true,
                Message = $" کاربر با موفقیت{userstate}  ثبت شد",
            };
           
        }
    }
}
