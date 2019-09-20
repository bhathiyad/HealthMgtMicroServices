using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMgt.AuthMicroService.DAO
{
    public class ApplicationDbContext : IdentityDbContext<AppUserEntity>
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
    }
}
