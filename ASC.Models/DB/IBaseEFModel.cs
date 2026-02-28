namespace ASC.Models.DB
{
    public interface IBaseEFModel<TId>
    {
        TId Id { get; set; }
    }
}

