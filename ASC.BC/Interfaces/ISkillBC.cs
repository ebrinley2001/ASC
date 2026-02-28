using ASC.Models.DB;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.BC.Interfaces
{
    public interface ISkillBC : IBaseEFBC<Skill, int>
    {
        List<Skill> GetRaceSkills(Race race);
        List<Skill> GetClassSkills(Class selectedClass);
        List<Skill> GetAttributeSkills(Attribute attribute);
        List<Skill> GetGeneralSkills();
    }
}
