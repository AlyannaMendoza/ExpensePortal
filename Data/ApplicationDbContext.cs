using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPEND_SMART.Models;

namespace SPEND_SMART.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        public DbSet<SPEND_SMART.Models.Expense> Expense { get; set; } = default!;
        public DbSet<SPEND_SMART.Models.Category> Category { get; set; } = default!;
        public DbSet<SPEND_SMART.Models.Income> Income { get; set; } = default!;
    }
}
