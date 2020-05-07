using Microsoft.EntityFrameworkCore;

namespace prof_sofware.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }
        public DbSet<Genus> Genus { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Friend> Friends { get; set; }
        
    }
}