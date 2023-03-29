using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;
using Learn1.Domain.Entities;

namespace Learn1.Application.Services.Users.Commands.RegesterUser
{
    public class RegesterUserServic : IRegesterUserService
    {
        private readonly IDatabaseContext _context;
        public RegesterUserServic(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegesterUserDto> Execute(RequestRegesterUserDto request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.FullName))
                {
                    return new ResultDto<ResultRegesterUserDto>()
                    {
                        Data=new ResultRegesterUserDto()
                        {
                            UserId=0,
                        },
                        isSuccess=false,
                        Message ="نام را وارد نمایید",
                    };

                }
                if (string.IsNullOrWhiteSpace(request.Email))
                {
                    return new ResultDto<ResultRegesterUserDto>()
                    {
                        Data=new ResultRegesterUserDto()
                        {
                            UserId=0,
                        },
                        isSuccess=false,
                        Message ="پست الکترونیک را وارد نمایید",
                    };

                }
                if (string.IsNullOrWhiteSpace(request.Password))
                {
                    return new ResultDto<ResultRegesterUserDto>()
                    {
                        Data=new ResultRegesterUserDto()
                        {
                            UserId=0,
                        },
                        isSuccess=false,
                        Message ="رمز عبور را وارد نمایید",
                    };

                }
                if (request.Password !=request.RePassword)
                {
                    return new ResultDto<ResultRegesterUserDto>()
                    {
                        Data=new ResultRegesterUserDto()
                        {
                            UserId=0,
                        },
                        isSuccess=false,
                        Message ="رمز عبور و تکرار آن برابر نیست",
                    };

                }



                User user = new User()
                {
                    Email=request.Email,
                    FullName=request.FullName,
                    Password=request.Password,

                };
                List<UserInRole> userInRoles = new List<UserInRole>();
                foreach (var item in request.roles)
                {
                    var roles = _context.Roles.Find(item.Id);
                    userInRoles.Add(new UserInRole
                    {
                        Role=roles,
                        RoleId=roles.Id,
                        User=user,
                        UserId=user.Id
                    });
                }
                user.UserInRoles = userInRoles;
                _context.Users.Add(user);
                _context.SaveChanges();
                return new ResultDto<ResultRegesterUserDto>()
                {
                    Data=new ResultRegesterUserDto()
                    {
                        UserId=user.Id,
                    },
                    isSuccess=true,
                    Message="ثبت نام کاربر انجام شد",
                };
            } 

            catch (Exception)
            {
                return new ResultDto<ResultRegesterUserDto>()
                {
                    Data = new ResultRegesterUserDto()
        {
            UserId=0,
                    },
                    isSuccess=false,
                    Message="ثبت نام کاربر انجام نشد"

                };

}

        }

    }
}
