using ASC.Models.DB;
using Microsoft.EntityFrameworkCore;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.BC
{
    public class ASCContext : DbContext
    {
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<BonusItem> BonusItem { get; set; }

        public ASCContext(DbContextOptions<ASCContext> options) 
            : base(options)
        { }
    }
}
