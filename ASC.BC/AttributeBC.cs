using ASC.BC.Interfaces;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.BC
{
    public class AttributeBC : BaseEFBC<Attribute, int, ASCContext>, IAttributeBC
    {
        public AttributeBC(ASCContext context) : base(context)
        {
        }
    }
}
