using ASC.Models.DB;

namespace ASC.BC.Interfaces
{
    public interface IBonusBC : IBaseEFBC<Bonus, int>
    {
        List<Bonus> GetClassBonuses(Class classToCheck);
    }
}
