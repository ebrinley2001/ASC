using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ASC.Models.DB
{
    public class BonusItem : IBaseEFModel<int>
    {
        public int Id { get; set; }
        public string? Effect { get; set; }
        public bool InRange { get; set; }

        [ForeignKey("BonusId")]
        [JsonIgnore]
        public virtual Bonus? Bonus { get; set; }

        [ForeignKey("SkillId")]
        [JsonIgnore]
        public virtual Skill? Skill { get; set; }
    }
}
