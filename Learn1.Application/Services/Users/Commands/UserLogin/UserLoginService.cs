using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Learn1.Common;
using Microsoft.EntityFrameworkCore;

namespace Learn1.Application.Services.Users.Commands.UserLogin
{
    public class UserLoginService : IUserLoginService
{
    private readonly IDatabaseContext _context;
    public UserLoginService(IDatabaseContext context)
    {
        _context = context;
    }
    public ResultDto<ResultUserloginDto> Execute(string Username, string Password)
    {

        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
        {
            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {

                },
                isSuccess = false,
                Message = "نام کاربری و رمز عبور را وارد نمایید",
            };
        }



        var user = _context.Users
            .Include(p => p.UserInRoles)
            .ThenInclude(p => p.Role)
            .Where(p => p.Email.Equals(Username)
        && p.IsActive == true)
        .FirstOrDefault();

        if (user == null)
        {
            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {

                },
                isSuccess = false,
                Message = "کاربری با این ایمیل در سایت فروشگاه دزفول ثبت نام نکرده است",
            };
        }

        var passwordHasher = new PasswordHasher();
        bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, Password);
        if (resultVerifyPassword == false)
        {
            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {

                },
                isSuccess = false,
                Message = "رمز وارد شده اشتباه است!",
            };
        }


        var roles = "";
        foreach (var item in user.UserInRoles)
        {
            roles += $"{item.Role.Name}";
        }


        return new ResultDto<ResultUserloginDto>()
        {
            Data = new ResultUserloginDto()
            {
                Roles = roles,
                UserId = user.Id,
                Name = user.FullName
            },
           isSuccess = true,
            Message = "ورود به سایت با موفقیت انجام شد",
        };


    }
}
}
