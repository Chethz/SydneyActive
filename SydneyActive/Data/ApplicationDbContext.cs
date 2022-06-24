using Microsoft.EntityFrameworkCore;
using SydneyActive.Models;

namespace SydneyActive.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }
    }
}

