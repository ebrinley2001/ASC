using ASC.Models.DB;

namespace ASC.BC.Interfaces
{
    public interface IBaseEFBC<TModel, TId>
        where TModel : IBaseEFModel<TId>
    {
        List<TModel> GetCollection();
        TModel GetById(TId id);
        int Delete(TModel entity);
        int Create(TModel entity);
        int Update(TModel entity);
    }
}

