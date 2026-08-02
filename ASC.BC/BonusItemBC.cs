using ASC.BC.Interfaces;
using ASC.Models.DB;

namespace ASC.BC
{
    public class BonusItemBC : BaseEFBC<BonusItem, int, ASCContext>, IBonusItemBC
    {
        public BonusItemBC(ASCContext context) : base(context)
        {
        }
    }
}
