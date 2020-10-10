using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi2.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions option):base(option)
        {

        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
