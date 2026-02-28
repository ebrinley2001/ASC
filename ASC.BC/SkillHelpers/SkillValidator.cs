using ASC.Models;
using ASC.Models.DB;
using ASC.Models.Enums;

namespace ASC.BC.SkillHelpers
{
    public static class SkillValidator
    {
        public static bool CheckLimit(this Skill skill, int amount, Character character)
        {
            switch (skill.Limit)
            {
                case Limit.None:
                    return true;
                case Limit.Once:
                    return amount == 1;
                case Limit.Twice:
                    return amount <= 2;

                case Limit.OncePerTwoLevels:
                    return amount <= Math.Max(1, character.Level.Id / 2);
                case Limit.OncePerThreeLevels:
                    return amount <= Math.Max(1, character.Level.Id / 3);
                case Limit.OncePerFourLevels:
                    return amount <= Math.Max(1, character.Level.Id / 4);

                case Limit.OncePerLevel:
                    return amount <= character.Level.Id;
                case Limit.TwoPerLevel:
                    return amount <= character.Level.Id * 2;
                case Limit.ThreePerLevel:
                    return amount <= character.Level.Id * 3;
            }
            return false;
        }

        public static bool CheckPrereq(this Skill skill, Character character)
        {
            switch (skill.Prerequisite)
            {
                case Prerequisite.None:
                    return true;
            }

            return false;
        }
    }
}
