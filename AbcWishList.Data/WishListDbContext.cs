using AbcWishList.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AbcWishList.Data;

public class WishListDbContext : DbContext, IWishListDbContext
{
    public DbSet<Item> WishList { get; set; }

    private readonly IConfiguration _configuration;

    public WishListDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("AbcWishList"));
    }

    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}
