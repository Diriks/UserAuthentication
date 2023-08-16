using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Models;

namespace UserAuthentication.Data
{
    public class UserAuthenticationContext : IdentityDbContext
    {
        public UserAuthenticationContext (DbContextOptions<UserAuthenticationContext> options)
            : base(options)
        {
        }

        public DbSet<UserAuthentication.Models.UserModel> UserModel { get; set; } = default!;
    }
}
