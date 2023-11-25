using Microsoft.EntityFrameworkCore;

namespace App20231125.DataModels
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany<Role>();
            modelBuilder.Entity<Role>().HasMany<User>();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Book2Shelf> Books2Shelfs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
