namespace ASC.BC.SkillHelpers
{
    public static class StatCalculator
    {
        public static Dictionary<string, Func<int, int>> HealthDelegates = new Dictionary<string, Func<int, int>>()
        {
            { "Vigor", Vigor },
        };

        public static Dictionary<string, Func<int, int>> StaminaDelegates = new Dictionary<string, Func<int, int>>()
        {
            { "Stamina", Stamina },
        };

        public static Dictionary<string, Func<int, int>> ArmorDelegates = new Dictionary<string, Func<int, int>>()
        {
            { "Armor Training", ArmorTraining },
        };

        public static Dictionary<string, Func<int, int>> NatArmorDelegates = new Dictionary<string, Func<int, int>>()
        {
            { "Natural Armor", NaturalArmor },
        };

        private static int Vigor(int amount)
        {
            return amount;
        }

        private static int Stamina(int amount)
        {
            return amount;
        }

        private static int NaturalArmor(int amount)
        {
            return amount;
        }

        private static int ArmorTraining(int amount)
        {
            return amount * 5;
        }
    }
}
