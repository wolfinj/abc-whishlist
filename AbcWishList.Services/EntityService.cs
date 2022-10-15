using AbcWishList.Core.Models;
using AbcWishList.Core.Services;
using AbcWishList.Data;
using Microsoft.EntityFrameworkCore;

namespace AbcWishList.Services;

public class EntityService<T> : IEntityService<T> where T : Entity
{
    protected IWishListDbContext Context;

    public EntityService(IWishListDbContext context)
    {
        Context = context;
    }

    public void Create(T entity)
    {
        Context.Set<T>().Add(entity);
        Context.SaveChanges();
    }

    public void Delete(T entity)
    {
        Context.Set<T>().Remove(entity);
        Context.SaveChanges();
    }

    public void Update(T entity)
    {
        Context.Entry(entity).State = EntityState.Modified;
        Context.SaveChanges();
    }

    public ICollection<T> GetAll()
    {
        return Context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        var result = Context.Set<T>().SingleOrDefault(e => e.Id == id);
        return result;
    }

    public IQueryable<T> Query()
    {
        return Context.Set<T>().AsQueryable();
    }
}
