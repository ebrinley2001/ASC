namespace ASC.Models.DB
{
    public class Class : IBaseEFModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int BaseHealth { get; set; }
        public int BaseStamina { get; set; }
        public int ArmorWear { get; set; }
        public int NaturalArmor { get; set; }
        public bool IsProfession { get; set; }
    }
}
