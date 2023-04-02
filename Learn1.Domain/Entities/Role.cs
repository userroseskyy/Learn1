using Learn1.Domain.Entities.Commons;

namespace Learn1.Domain.Entities
{
    public class Role:BaseEntity
    {
      
        public string Name { get; set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
    }
}
