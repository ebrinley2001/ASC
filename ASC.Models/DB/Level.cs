namespace ASC.Models.DB
{
    public class Level : IBaseEFModel<int>
    {
        //ID Doesnt increment and is the level
        public int Id { get; set; }
        public int XpThreshold { get; set; }
        public int BaseHp { get; set; }
        public int BaseStamina { get; set; }
        public int Attributes { get; set; }
        public int Roles { get; set; }
    }
}
