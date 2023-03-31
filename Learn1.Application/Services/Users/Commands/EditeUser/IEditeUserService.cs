using Learn1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services.Users.Commands.EditeUser
{
    public interface IEditeUserService
    {
        public ResultDto Execute(RequestEdituserDto request);
    }
}
