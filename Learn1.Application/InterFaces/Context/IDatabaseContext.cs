using Learn1.Domain.Entities;
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
        int SaveChenges(bool acceptAllChangesOnSuccess);
        int SaveChenges();
        Task<int> SaveChengesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken=new CancellationToken());
        Task<int> SaveChengesAsync( CancellationToken cancellationToken=new CancellationToken());

    }
}
