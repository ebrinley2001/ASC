using ASC.Models.DB;

namespace ASC.BC.Interfaces
{
    public interface ILevelBC : IBaseEFBC<Level, int>
    {
        Level? GetCurrentLevel(int xp);
    }
}
