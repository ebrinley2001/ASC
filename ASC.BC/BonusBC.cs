using ASC.BC.Interfaces;
using ASC.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace ASC.BC
{
    public class BonusBC : BaseEFBC<Bonus, int, ASCContext>, IBonusBC
    {
        private ASCContext _context;
        public BonusBC(ASCContext context) : base(context)
        {
            _context = context;
        }

        public List<Bonus> GetClassBonuses(Class classToCheck)
        {
            return _context.Set<Bonus>()
                .Include(s => s.Class)
                .Include(s => s.BonusItems)
                .ThenInclude(i => i.Skill)
                .Where(s => s.Class == classToCheck)
                .AsNoTracking()
                .ToList();
        }
    }
}
