using Microsoft.EntityFrameworkCore;

namespace BackEnd_S5_L1.Models.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Loan>()
                .HasKey(l => new { l.ProductId, l.UserId });
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Product)
                .WithMany()
                .HasForeignKey(l => l.ProductId);
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId);
        }
    }
}
