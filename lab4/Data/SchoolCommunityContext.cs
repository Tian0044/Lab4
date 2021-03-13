using lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }

        public DbSet<CommunityMembership> CommunityMemberships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityMembership>()
                .HasKey(c => new { c.StudentID, c.CommunityID });
        }
    }
}