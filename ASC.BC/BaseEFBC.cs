using ASC.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace ASC.BC
{
    public abstract class BaseEFBC<TModel, TId, TDbContext>
        where TModel : class, IBaseEFModel<TId>, new()
        where TDbContext : DbContext
    {
        private readonly TDbContext _context;

        public BaseEFBC(TDbContext context)
        {
            _context = context;
        }

        public virtual List<TModel> GetCollection()
        {
            return _context.Set<TModel>().ToList();
        }

        public virtual TModel GetById(TId id)
        {
            return _context.Set<TModel>().Find(id);
        }

        public virtual int Delete(TModel entity)
        {
            _context.Set<TModel>().Remove(entity);
            return _context.SaveChanges();
        }

        public virtual int Create(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
            return _context.SaveChanges();
        }

        public virtual int Update(TModel entity)
        {
            _context.Set<TModel>().Update(entity);
            return _context.SaveChanges();
        }
    }
}
