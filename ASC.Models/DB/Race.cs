namespace ASC.Models.DB
{
    public class Race : IBaseEFModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
