using IssueTrackingapp.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTrackingapp.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
