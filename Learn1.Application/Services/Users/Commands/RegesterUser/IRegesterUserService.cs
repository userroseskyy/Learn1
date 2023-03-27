using Learn1.Application.Services.Users.Queries.GetUsers;
using Learn1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Learn1.Application.Services.Users.Commands.RegesterUser.RegesterUserServic;

namespace Learn1.Application.Services.Users.Commands.RegesterUser
{
    public interface IRegesterUserService
    {
        ResultDto<ResultRegesterUserDto> Execute(RequestRegesterUserDto request);
    }
}
