using Microsoft.EntityFrameworkCore;

namespace EFComponent
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=Inventario;Integrated Security=True;Trusted_Connection=True;Trust Server Certificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(b => b.ProductId);
            modelBuilder.Entity<Product>()
                .Property(b => b.ProductId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<User>()
                .HasKey(b => b.UserId);
            modelBuilder.Entity<User>()
                .Property(b => b.UserId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().ToTable("Users");

        }
    }
}
