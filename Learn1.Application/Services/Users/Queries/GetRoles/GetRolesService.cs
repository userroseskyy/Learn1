using Learn1.Application.InterFaces.Context;
using Learn1.Common.Dto;

namespace Learn1.Application.Services.Users.Queries.GetUsers
{
    public class GetRolesService : IGetRolesService
    {
        private readonly IDatabaseContext _context;
        public GetRolesService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<RolesDto>> Execute()
        {
            var roles = _context.Roles.ToList().Select(p => new RolesDto
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
            return new ResultDto<List<RolesDto>>()
            {
                Data = roles,
                IsSuccess = true,
                Messege="",
            };

        }
    }
}
