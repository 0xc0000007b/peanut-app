using Microsoft.EntityFrameworkCore;
using Core.Entities;


namespace Infrastructure.Data;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
        
    }
    public DbSet<ProductEntity> Products { get; set; }
    
}