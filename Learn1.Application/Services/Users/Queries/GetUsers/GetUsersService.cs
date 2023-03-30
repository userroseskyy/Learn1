using Learn1.Application.InterFaces.Context;
using Learn1.Common;

namespace Learn1.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersServices
    {
        private readonly IDatabaseContext _context;
        public GetUsersService(IDatabaseContext context)
        {
            _context = context;

        }
        public ResultGetUsersDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Searchkey))
            {
                users=users.Where(p => p.FullName.Contains(request.Searchkey)&&p.Email.Contains(request.Searchkey));
            }
            int rowsCount = 0;
            var usersList= users.ToPaged(request.Page, 20,out rowsCount).Select(p => new GetUsersDto
            {
                Email = p.Email,
                FullName = p.FullName,
                Id = p.Id,
                IsActive=p.IsActive,
                
            }).ToList();
            return new ResultGetUsersDto
            {
                Rows=rowsCount,
                Users=usersList,
            };

        }
    }
}
