using API.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<Order> Orders => Set<Order>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new List<Product>
                {
                    new Product { Id=1, Name="Apple Watch Series 1", Description="Saat açıklaması", ImageUrl="1.jpg", Price=7000, IsActive=true, Stock=100  },
                    new Product { Id=2, Name="Apple Watch Series 2", Description="Saat açıklaması", ImageUrl="2.jpg", Price=8000, IsActive=true, Stock=100  },
                    new Product { Id=3, Name="Apple Watch Series 3", Description="Saat açıklaması", ImageUrl="3.jpg", Price=9000, IsActive=false, Stock=100  },
                    new Product { Id=4, Name="Xiaomi Redmi Watch 1", Description="Saat açıklaması", ImageUrl="4.jpg", Price=10000, IsActive=true, Stock=100  },
                    new Product { Id=5, Name="Xiaomi Redmi Watch 2", Description="Saat açıklaması", ImageUrl="5.jpg", Price=10000, IsActive=true, Stock=100  },
                    new Product { Id=6, Name="Xiaomi Redmi Watch 3", Description="Saat açıklaması", ImageUrl="6.jpg", Price=10000, IsActive=true, Stock=100  },
                    new Product { Id=7, Name="Xiaomi Redmi Watch 4", Description="Saat açıklaması", ImageUrl="7.jpg", Price=10000, IsActive=true, Stock=100  }
                }
            );
        }
    }
}