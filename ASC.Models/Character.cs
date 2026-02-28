using ASC.Models.DB;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int XpAmount { get; set; }
        public int XpToSpend {  get; set; }
        public int MaxArmor { get; set; }
        public int NaturalArmor { get; set; }
        public Level Level { get; set; }
        public Race Race { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<KeyValuePair<int, Skill>> Skills { get; set; }
        public List<Class> Classes { get; set; }
    }
}
