using Learn1.Application.InterFaces.Context;
using Learn1.Common.Roles;
using Learn1.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learn1.Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id=1, Name=nameof(UserRoles.Admin), });
            modelBuilder.Entity<Role>().HasData(new Role { Id=2, Name=nameof(UserRoles.Operator), });
            modelBuilder.Entity<Role>().HasData(new Role { Id=3, Name=nameof(UserRoles.Customer), });

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
        }





    }
}
