using System.Data.Entity;
using Barebones.Models;

namespace Barebones.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=BarebonesContext") { }

        public DbSet<BoneEntity> BoneEntities { get; set; }
        public DbSet<BodyEntity> BodyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}