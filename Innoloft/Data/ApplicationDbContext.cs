using Innoloft.Models;
using Microsoft.EntityFrameworkCore;

namespace Innoloft.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        
        public DbSet<Models.TimeZone> TimeZones { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistration { get; set; }
    }
}
