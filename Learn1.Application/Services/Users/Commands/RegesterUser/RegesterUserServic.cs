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
            User user = new User()
            {
                Email=request.Email,
                FullName=request.FullName,

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
            _context.SaveChenges();
            return new ResultDto<ResultRegesterUserDto>()
            {
                Data=new ResultRegesterUserDto()
                {
                    UserId=user.Id,
                },
                IsSuccess=true,
                Messege="ثبت نام کاربر انجام شد",
            };
        }
        
    }
}
