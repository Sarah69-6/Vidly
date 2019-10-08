using System;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.Controllers
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; internal set; }

      
    }
}