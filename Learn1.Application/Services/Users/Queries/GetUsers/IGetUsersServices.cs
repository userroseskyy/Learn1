namespace Learn1.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersServices
    {
        List<GetUsersDto> Execute(RequestGetUserDto request);
    }
}
