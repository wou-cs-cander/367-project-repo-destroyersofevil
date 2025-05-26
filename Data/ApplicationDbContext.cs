using Microsoft.EntityFrameworkCore;
using _367_project_repo_destroyersofevil.Models;

namespace _367_project_repo_destroyersofevil.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
