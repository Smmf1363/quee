using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using smmf8quee.Models;

namespace smmf8quee.Contexts
{
    public class TurnContext : DbContext
    {
        public TurnContext(DbContextOptions<TurnContext> options)
            :base(options)
        {
            
        }
        public DbSet<Turns> Turns{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
