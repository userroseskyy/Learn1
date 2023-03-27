namespace Learn1.Application.Services.Users.Commands.RegesterUser
{
    public class RequestRegesterUserDto
    {
        
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string RePassword { get; set; }
        
        public List<RolesInRegesterUserDto> roles { get; set; }
    }
}
