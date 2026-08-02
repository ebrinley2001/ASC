using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ASC.Models.DB
{
    public class Bonus : IBaseEFModel<int>
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        [ForeignKey("ClassId")]
        [JsonIgnore]
        public virtual Class? Class { get; set; }

        [ForeignKey("RaceId")]
        [JsonIgnore]
        public virtual Race? Race { get; set; }

        [ForeignKey("LevelId")]
        [JsonIgnore]
        public virtual Level? Level { get; set; }

        [JsonIgnore]
        public virtual IList<BonusItem> BonusItems { get; set; } = new List<BonusItem>();
    }
}
