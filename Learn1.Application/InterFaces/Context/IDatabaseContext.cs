using Learn1.Domain.Entities;
using Learn1.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.InterFaces.Context
{
   public interface IDatabaseContext
    {
         DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
         DbSet<UserInRole> UserInRoles { get; set; }
        DbSet<Category> categories { get; set; }



        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
