namespace Learn1.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersServices
    {
        ResultGetUsersDto Execute(RequestGetUserDto request);
    }
}
