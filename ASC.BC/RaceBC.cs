using ASC.BC.Interfaces;
using ASC.Models.DB;

namespace ASC.BC
{
    public class RaceBC : BaseEFBC<Race, int, ASCContext>, IRaceBC
    {
        public RaceBC(ASCContext context) : base(context)
        {
        }
    }
}
