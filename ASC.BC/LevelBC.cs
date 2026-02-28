using ASC.BC.Interfaces;
using ASC.Models.DB;

namespace ASC.BC
{
    public class LevelBC : BaseEFBC<Level, int, ASCContext>, ILevelBC
    {
        private ASCContext _context;
        public LevelBC(ASCContext context) : base(context)
        {
            _context = context;
        }

        public Level? GetCurrentLevel(int xp)
        {
            return _context.Set<Level>().OrderBy(x => x.Id).LastOrDefault(l => l.XpThreshold <= xp);
        }
    }
}
