using ASC.BC.Interfaces;
using ASC.Models.DB;

namespace ASC.BC
{
    public class ClassBC : BaseEFBC<Class, int, ASCContext>, IClassBC
    {
        public ClassBC(ASCContext context) : base(context)
        {
        }
    }
}
