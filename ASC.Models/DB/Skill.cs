using ASC.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ASC.Models.DB
{
    public class Skill : IBaseEFModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int XPCost { get; set; }
        public int StaminaCost { get; set; }
        public Prerequisite Prerequisite { get; set; }
        public Limit Limit { get; set; }
        public bool IsAttributeSkill { get; set; }
        public bool IsRacialSkill { get; set; }
        public bool IsCombatSkill { get; set; }

        //FKs
        public int? ClassId { get; set; }
        public int? RaceId { get; set; }
        public int? AttributeId { get; set; }

        [ForeignKey("ClassId")]
        [JsonIgnore]
        public Class? Class { get; set; }

        [ForeignKey("RaceId")]
        [JsonIgnore]
        public Race? Race { get; set; }

        [ForeignKey("AttributeId")]
        [JsonIgnore]
        public Attribute? Attribute { get; set; }
    }
}
