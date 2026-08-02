using ASC.Models.DB;

namespace ASC.BC.SkillHelpers
{
    public static class SkillExtensions
    {
        public static string GetSource(this Skill skill)
        {
            if (skill.IsRacialSkill && skill.Race != null)
            {
                return skill.Race.Name;
            }
            else if (skill.IsAttributeSkill && skill.Attribute != null)
            {
                return skill.Attribute.Name;
            }
            else if (skill.Class != null)
            {
                return skill.Class.Name;
            }
            else 
            {
                return "General";
            }
        }
    }
}
