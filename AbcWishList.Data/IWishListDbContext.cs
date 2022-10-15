using AbcWishList.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AbcWishList.Data;

public interface IWishListDbContext
{
    DbSet<T> Set<T>() where T : class;
    EntityEntry<T> Entry<T>(T entity) where T : class;

    DbSet<Item> WishList { get; set; }
    int SaveChanges();
    Task<int> SaveChangesAsync();
}
