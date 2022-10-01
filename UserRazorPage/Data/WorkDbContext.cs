using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserRazorPage.Entities;

namespace UserRazorPage.Data
{
    public class WorkDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options)
        {

        }

    }
}
