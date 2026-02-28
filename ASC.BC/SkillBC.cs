using ASC.BC.Interfaces;
using ASC.Models.DB;
using Microsoft.EntityFrameworkCore;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.BC
{
    public class SkillBC : BaseEFBC<Skill, int, ASCContext>, ISkillBC
    {
        private ASCContext _context;
        public SkillBC(ASCContext context) : base(context)
        {
            _context = context;
        }

        public List<Skill> GetRaceSkills(Race race)
        {
            return _context.Set<Skill>().Include(s => s.Race).Where(s => s.Race == race).ToList();
        }

        public List<Skill> GetClassSkills(Class selectedClass)
        {
            return _context.Set<Skill>().Include(s => s.Class).Where(s => s.Class == selectedClass).ToList();
        }
        public List<Skill> GetAttributeSkills(Attribute attribute)
        {
            return _context.Set<Skill>().Include(s => s.Attribute).Where(s => s.Attribute == attribute).ToList();
        }

        public List<Skill> GetGeneralSkills()
        {
            return _context.Set<Skill>().Where(s => !s.IsRacialSkill && !s.IsAttributeSkill && s.Class == null).ToList();
        }
    }
}
